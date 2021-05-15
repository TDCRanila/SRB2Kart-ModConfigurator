using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

using Microsoft.WindowsAPICodePack.Dialogs;

using SRB2KModConfigurator.Config;
using SRB2KModConfigurator.Forms;
using SRB2KModConfigurator.Data;

namespace SRB2KModConfigurator
{
    public partial class ConfigurationPanel : Form
    {
        private StarterPage parentFormRef;

        private GeneralSettingsPanel generalSettingsPanelRef;
        private VideoSettingsPanel videoSettingsPanelRef;
        private AudioSettingsPanel audioSettingsPanelRef;
        private ServerSettingsPanel serverSettingsPanelRef;

        private DirectoryInfo currentModFolderInfo;
        private Dictionary<TreeNode, string> currentSelectedModItems;
        private FileInfo currentTargetExecutableInfo;
        private string currentTargetExecutablePath;
        private ConfigurationSettingsDataStruct configSettings;

        private bool isModFolderLocationValid;
        private bool isTargetExecutableLocationValid;
        private bool isConfigurationValid;

        private bool enableTreeViewAfterCheck;

        private const string bonusCharacterPackFileName = "bonuschars.kart";

        public ConfigurationPanel()
        {
            InitializeComponent();

            InitiliazeConfigurator();

            SetSettingsControlStatus(CP_CheckboxEnableOverrideSettings.Checked);
        }

        public ConfigurationPanel(SRB2ConfigFile loadedConfigFile)
        {
            InitializeComponent();

            InitiliazeConfigurator();

            this.LoadData(loadedConfigFile);

            generalSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.generalSettings);
            videoSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.videoSettings);
            audioSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.audioSettings);
            serverSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.serverSettings);
        }

        private void InitiliazeConfigurator()
        {
            currentModFolderInfo        = null;
            currentSelectedModItems     = new Dictionary<TreeNode, string>();
            currentTargetExecutableInfo = null;
            currentTargetExecutablePath = "";

            enableTreeViewAfterCheck    = true;

            SetTargetExecutableValidationStatus(false);
            SetModFolderValidationStatus(false);
            CP_ModFolderTreeView.CheckBoxes = true;

            generalSettingsPanelRef = new GeneralSettingsPanel();
            videoSettingsPanelRef   = new VideoSettingsPanel();
            audioSettingsPanelRef   = new AudioSettingsPanel();
            serverSettingsPanelRef  = new ServerSettingsPanel();
            DockSettingsPanel(generalSettingsPanelRef, CP_PanelGeneralSettings);
            DockSettingsPanel(videoSettingsPanelRef, CP_PanelVideoSettings);
            DockSettingsPanel(audioSettingsPanelRef, CP_PanelAudioSettings);
            DockSettingsPanel(serverSettingsPanelRef, CP_PanelServerSettings);

            generalSettingsPanelRef.DisableBonusCharacterPackOption();
        }

        private void ConfigurationPanel_Load(object sender, EventArgs e)
        {
            parentFormRef = (StarterPage)this.ParentForm;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        #region Implementation - Child Panels

        private void DockSettingsPanel(Form childFormToDock, Panel dock)
        {
            // Set new child form and the proper form settings.
            childFormToDock.TopLevel        = false;
            childFormToDock.FormBorderStyle = FormBorderStyle.None;
            childFormToDock.Dock            = DockStyle.Fill;

            dock.Controls.Clear();
            dock.Controls.Add(childFormToDock);
            dock.Tag        = childFormToDock;
            dock.Visible    = true;

            childFormToDock.BringToFront();
            childFormToDock.Show();
        }

        #endregion

        #region Implementation - User Interface

        private void ClearTargetExecutableInfo()
        {
            currentTargetExecutableInfo = null;
            currentTargetExecutablePath = "";
            SetTargetExecutableValidationStatus(false);
    }

        private void ClearModFolder()
        {
            currentModFolderInfo = null;
            currentSelectedModItems.Clear();
            CP_ModFolderTreeView.Nodes.Clear();
            SetModFolderValidationStatus(false);
        }

        private void LoadData(SRB2ConfigFile data)
        {
            CP_TextboxConfigurationName.Text            = data.configurationDisplayName;
            CP_CheckboxEnableOverrideSettings.Checked   = data.enableOverrideSettings;

            LoadModFolder(data.mainModFolderPath);
            UpdateModFolderTreeViewer(data.modFiles);
            LoadTargetExecutableInfo(data.targetFilePath);
        }

        private bool LoadTargetExecutableInfo(string targetExecutablePathLocation)
        {
            FileInfo newFileInfo = new FileInfo(targetExecutablePathLocation);
            if (!newFileInfo.Exists)
            {
                // Error Message.
                ClearTargetExecutableInfo();
                return false;
            }

            if (currentTargetExecutableInfo != null && currentTargetExecutableInfo == newFileInfo)
            {
                // Ignore.
                return true;
            }

            string textPath = targetExecutablePathLocation;
            bool isValidEntry = textPath.Any() && textPath.Contains(".exe", StringComparison.InvariantCultureIgnoreCase);
            if (!isValidEntry)
            {
                // Error Message
                // POP UP : Is Not An Executable.
                MessageBox.Show("Selected Target is not an executable file.", "Failed To Select Target", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTargetExecutableInfo();
                return false;
            }

            currentTargetExecutableInfo = newFileInfo;
            currentTargetExecutablePath = targetExecutablePathLocation;

            // Visual
            CP_TextBoxTargetExecutableLocation.Text = targetExecutablePathLocation;
            SetTargetExecutableValidationStatus(true);
            
            return true;
        }

        private bool LoadModFolder(string modFolderPathLocation)
        {
            if (modFolderPathLocation.Length == 0)
            {
                return false;
            }    

            DirectoryInfo newModFolderInfo = new DirectoryInfo(modFolderPathLocation);
            if (!newModFolderInfo.Exists)
            {
                // Error Message.
                SetModFolderValidationStatus(false);
                return false;
            }

            if (currentModFolderInfo != null && currentModFolderInfo == newModFolderInfo)
            {
                // Ignore.
                SetModFolderValidationStatus(false);
                return false;
            }

            currentModFolderInfo = newModFolderInfo;

            // Visual
            CP_TextBoxModFolderLocation.Text = modFolderPathLocation;
            SetModFolderValidationStatus(true);

            // Order TreeView to load in data.
            FeedModFolderTreeViewer();

            // Only expand the childeren of the top-most node.
            foreach (TreeNode childNode in CP_ModFolderTreeView.Nodes)
            {
                childNode.Expand();
            }

            return true;
        }

        private void UpdateModFolderTreeViewer(List<string> modList)
        {
            if (modList.Count == 0)
            {
                // Early Exit.
                return;
            }

            List<string> missingMods = new List<string>();

            TreeNodeCollection treeViewNodeCollection =  CP_ModFolderTreeView.Nodes;
            // Find mods that were present in the modlist/configuration.
            foreach (string modPath in modList)
            {
                TreeNode[] foundNodes = treeViewNodeCollection.Find(modPath, true);
                if (foundNodes.Length <= 0)
                {
                    // Warning, tried to find item that was present in configuration, but can
                    //          no longer be found in the mod folder.
                    // Action , continue but just warn user fater loading.
                    missingMods.Add(modPath);
                    continue;
                }

                if (foundNodes.Length >= 2)
                {
                    // Warning, multiple nodes found regarding a selected mod. Shouldn't
                    // happen unless the OS allows items of the same name in explorer.
                }

                foreach (TreeNode node in foundNodes)
                {
                    node.Checked = true;
                }
            }

            // Update folder nodes whether all childeren nodes are selected.
            bool InternalRecursiveFunc(TreeNode nodeParent)
            {
                if (nodeParent.GetNodeCount(true) == 0)
                {
                    return nodeParent.Checked;
                }

                bool areAllChilderenChecked     = true;
                bool hasSomeChilderenChecked    = false;
                foreach (TreeNode childNode in nodeParent.Nodes)
                {
                    bool result = InternalRecursiveFunc(childNode);
                    areAllChilderenChecked  = result;
                    
                    if (result) 
                        hasSomeChilderenChecked = result;
                }

                if (!nodeParent.Checked)
                    nodeParent.Checked = areAllChilderenChecked;

                if (hasSomeChilderenChecked)
                    nodeParent.Expand();

                return areAllChilderenChecked;
            }

            // Go through all the tree nodes and update their checked state.
            // If all childeren are selected, the parent of those childeren should
            // also be selected.
            // Disable the aftercheck callback on the treenodes as it will cause
            // issues with the function below.
            enableTreeViewAfterCheck    = false;
            
            TreeNode treeParentNode     = CP_ModFolderTreeView.Nodes[0];
            InternalRecursiveFunc(treeParentNode);
            
            enableTreeViewAfterCheck    = true;

            // Warn User.
            string info;
            if (missingMods.Count > 0)
            {
                using (StringWriter writer = new StringWriter())
                {
                    foreach (string mod in missingMods)
                        writer.Write(mod + "\n");

                    info = writer.ToString();
                }

                // POP UP : Missing mods when updating configuration.
                MessageBox.Show("Selected mod files are missing during (re)loading of the mod folder." + '\n' + info
                    , "Missing Selected Mod Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DialogResult result = MessageBox.Show("Do you want to copy the missing mod filepaths to your clipboard?", "Clipboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Clipboard.SetText(info);
            }
        }

        private bool FeedModFolderTreeViewer()
        {
            if (!currentModFolderInfo.Exists)
            {
                // Error Message
                return false;
            }

            HelperFunctionBuildTree(true, currentModFolderInfo, CP_ModFolderTreeView.Nodes);

            HelpFunctionAlternateNodeColours(CP_ModFolderTreeView.Nodes);

            return true;
        }

        private void HelperFunctionBuildTree(bool clearTreeCollection, DirectoryInfo directoryInfo, TreeNodeCollection nodeCollection)
        {
            if (clearTreeCollection)
            {
                nodeCollection.Clear();
            }

            TreeNode curNode = nodeCollection.Add(directoryInfo.Name);
            
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                HelperFunctionBuildTree(false, subdir, curNode.Nodes);
            }
        }

        private void HelpFunctionAlternateNodeColours(TreeNodeCollection nodeCollection)
        {
            // Local Recursive Function.
            bool InternalRecursiveFunc(TreeNode nodeParent, bool isAlternateNode)
            {
                if (isAlternateNode)
                {
                    isAlternateNode = false;
                    nodeParent.BackColor = Color.FromArgb(255, 75, 75, 25);
                }
                else
                {
                    isAlternateNode = true;
                    nodeParent.BackColor = Color.FromArgb(255, 55, 55, 55);
                }

                if (nodeParent.IsExpanded)
                {
                    foreach (TreeNode childNode in nodeParent.Nodes)
                    {
                        isAlternateNode = InternalRecursiveFunc(childNode, isAlternateNode);
                    }
                }

                return isAlternateNode;
            }

            // Start Recursive Process.
            foreach (TreeNode nodeParent in nodeCollection)
            {
                InternalRecursiveFunc(nodeParent, true);
            }
        }

        private void SetTargetExecutableValidationStatus(bool isValid)
        {
            isTargetExecutableLocationValid = isValid;

            CheckConfigurationValiditity();

            Image image                                     = isValid ? Properties.Resources.spr_checkmark : Properties.Resources.spr_crosss;
            CP_PictureBoxTargetExecutableValidation.Image   = image;

            if (generalSettingsPanelRef != null)
            {
                if (CheckBonusCharacterPackValidation())
                    generalSettingsPanelRef.EnableBonusCharacterPackOption();
                else
                    generalSettingsPanelRef.DisableBonusCharacterPackOption();
            }
        }

        private void SetModFolderValidationStatus(bool isValid)
        {
            isModFolderLocationValid = isValid;

            CheckConfigurationValiditity();

            Image image                             = isValid ? Properties.Resources.spr_checkmark : Properties.Resources.spr_crosss;
            CP_PictureBoxModFolderValidation.Image  = image;
        }

        private void CheckConfigurationValiditity()
        {
            isConfigurationValid = isTargetExecutableLocationValid && isModFolderLocationValid;

            CP_ButtonLaunchConfiguration.Enabled    = isConfigurationValid;
            CP_ButtonSaveConfiguration.Enabled      = isConfigurationValid;
            CP_ButtonExportConfigFileDialog.Enabled = isConfigurationValid;

            Image image                                     = isConfigurationValid ? null : Properties.Resources.spr_crosss;
            CP_ButtonLaunchConfiguration.BackgroundImage    = image;
            CP_ButtonSaveConfiguration.BackgroundImage      = image;
            CP_ButtonExportConfigFileDialog.BackgroundImage = image;
        }

        private void SetSettingsControlStatus(bool enabled)
        {
            IEnumerable<Control> GetAllChildren(Control root)
            {
                Stack<Control> controlStack = new Stack<Control>();
                controlStack.Push(root);

                while (controlStack.Any())
                {
                    Control next = controlStack.Pop();
                    foreach (Control child in next.Controls)
                        controlStack.Push(child);
                    yield return next;
                }
            }

            List<Control> childPanelControls = new List<Control>();
            childPanelControls.AddRange(GetAllChildren(generalSettingsPanelRef.Parent));
            childPanelControls.AddRange(GetAllChildren(videoSettingsPanelRef.Parent));
            childPanelControls.AddRange(GetAllChildren(audioSettingsPanelRef.Parent));
            childPanelControls.AddRange(GetAllChildren(serverSettingsPanelRef.Parent));

            foreach (TextBox textBox in childPanelControls.OfType<TextBox>())
                textBox.Enabled = enabled;

            foreach (ComboBox comboBox in childPanelControls.OfType<ComboBox>())
                comboBox.Enabled = enabled;

            foreach (CheckBox checkBox in childPanelControls.OfType<CheckBox>())
                checkBox.Enabled = enabled;

            foreach (Button button in childPanelControls.OfType<Button>())
                button.Enabled = enabled;

        }

        public bool CheckBonusCharacterPackValidation()
        {
            if (currentTargetExecutableInfo == null)
                return false;

            string dirOfExe = currentTargetExecutablePath.Replace(currentTargetExecutableInfo.Name, "");
            string fileName = bonusCharacterPackFileName;
            string fullPath = (dirOfExe + fileName);

            FileInfo tempFileInfo = new FileInfo(fullPath);
            if (!tempFileInfo.Exists)
                return false;
            else
                return true;
        }

        #endregion // End of region ~ Implementation. - 

        #region Implementation - Exporting & Saving

        private SRB2ConfigFile ConstructConfigurationData()
        {
            // Fetch Data from Child Settings Panels.
            configSettings.generalSettings  = generalSettingsPanelRef.ReturnData();
            configSettings.videoSettings    = videoSettingsPanelRef.ReturnData();
            configSettings.audioSettings    = audioSettingsPanelRef.ReturnData();
            configSettings.serverSettings   = serverSettingsPanelRef.ReturnData();

            // Prepare Config
            SRB2ConfigFile configFile = new SRB2ConfigFile();

            configFile.configurationDisplayName  = CP_TextboxConfigurationName.Text;
            configFile.enableOverrideSettings    = CP_CheckboxEnableOverrideSettings.Checked;
            
            configFile.targetFilePath            = currentTargetExecutablePath;
            configFile.mainModFolderPath         = currentModFolderInfo.ToString();
            
            foreach (string modItem in currentSelectedModItems.Values)
                configFile.modFiles.Add(modItem);
            
            configFile.configSettingsData        = configSettings;

            return configFile;
        }

        private void LaunchConfiguration()
        {
            LauncherHelper.LaunchConfiguration(ConstructConfigurationData());
        }

        private void SaveConfiguration()
        {
            // Collect Settings Data.
            SRB2ConfigFile newConfigFile = ConstructConfigurationData();

            // Save File
            CommonSaveFileDialog configSaveFileDialog = new CommonSaveFileDialog();

            var configFileFilter = new CommonFileDialogFilter("SRB2Kart Config", ".srb2k-config");
            var allFilter        = new CommonFileDialogFilter("All Files", "*.*");
            configSaveFileDialog.Filters.Add(configFileFilter);
            configSaveFileDialog.Filters.Add(allFilter);

            configSaveFileDialog.AlwaysAppendDefaultExtension   = true;
            configSaveFileDialog.DefaultExtension               = ".srb2k-config";

            if (configSaveFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else
            {
                string fileName = configSaveFileDialog.FileName;
                using (FileStream fs = File.Create(fileName))
                {
                    if (fs.CanWrite)
                    {
                        using (StreamWriter writer  = new StreamWriter(fs))
                        {
                            FileInfo fileInfo = new FileInfo(fileName);
                            newConfigFile.configurationDisplayName = fileInfo.Name;
                    
                            // Visual
                            CP_TextboxConfigurationName.Text = fileInfo.Name;
                    
                            writer.Write(newConfigFile.CreateJSONString());
                        }
                    }
                }

                return;
            }
        }

        private void ExportConfiguration()
        {
            // Collect Settings Data.
            SRB2ConfigFile newConfigFile = ConstructConfigurationData();

            // Save File & Dialog
            CommonSaveFileDialog exportBatchFileDialog = new CommonSaveFileDialog();

            var batchFilter = new CommonFileDialogFilter("Batch File", ".bat");
            var allFilter   = new CommonFileDialogFilter("All Files", "*.*");
            exportBatchFileDialog.Filters.Add(batchFilter);
            exportBatchFileDialog.Filters.Add(allFilter);

            exportBatchFileDialog.AlwaysAppendDefaultExtension   = true;
            exportBatchFileDialog.DefaultExtension               = ".bat";
            exportBatchFileDialog.DefaultFileName                = CP_TextboxConfigurationName.Text;  

            if (exportBatchFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else
            {
                string fileName = exportBatchFileDialog.FileName;
                using (FileStream fs = File.Create(fileName))
                {
                    if (fs.CanWrite)
                    {
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.Write(newConfigFile.CreateLauncherString());
                        }
                    }
                }

                return;
            }
        }

        #endregion

        #region Callbacks

        private void CP_CheckboxEnableOverrideSettings_CheckedChanged(object sender, EventArgs e)
        {
            SetSettingsControlStatus(CP_CheckboxEnableOverrideSettings.Checked);
        }

        private void CP_ButtonLaunchConfiguration_Click(object sender, EventArgs e)
        {
            LaunchConfiguration();
        }

        private void CP_ButtonSaveConfiguration_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
        }

        private void CP_ButtonExportConfigFileDialog_Click(object sender, EventArgs e)
        {
            ExportConfiguration();
        }

        private void CP_ButtonReturnStarterPage_Click(object sender, EventArgs e)
        {
            if (parentFormRef != null)
            {
                StarterPage starterPageRef = (StarterPage)this.ParentForm;
                starterPageRef.ShowStarterPageElements();
                starterPageRef.RefreshStarterPage();
            }

            this.Close();
        }

        private void CP_TextBoxTargetExecutableLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = CP_TextBoxTargetExecutableLocation;
                LoadTargetExecutableInfo(CP_TextBoxTargetExecutableLocation.Text);
            }
        }

        private void CP_ButtonRefreshTargetExecutable_Click(object sender, EventArgs e)
        {
            HelpFunctionAlternateNodeColours(CP_ModFolderTreeView.Nodes);
            TextBox textBox = CP_TextBoxTargetExecutableLocation;
            LoadTargetExecutableInfo(CP_TextBoxTargetExecutableLocation.Text);
        }

        private void CP_ButtonFileDialogTargetExecutable_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog targetExecutableFileDialog = new CommonOpenFileDialog();

            var exeFilter = new CommonFileDialogFilter("EXE Files", "*.exe");
            var allFilter = new CommonFileDialogFilter("All Files", "*.*");
            targetExecutableFileDialog.Filters.Add(exeFilter);
            targetExecutableFileDialog.Filters.Add(allFilter);
            
            targetExecutableFileDialog.Title                    = "Select your SRB2Kart EXE.";
            targetExecutableFileDialog.IsFolderPicker           = false;
            targetExecutableFileDialog.AllowNonFileSystemItems  = false;
            targetExecutableFileDialog.Multiselect              = false;
            targetExecutableFileDialog.AllowPropertyEditing     = true;
            targetExecutableFileDialog.EnsurePathExists         = true;

            if (targetExecutableFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else
            {
                string[] files = targetExecutableFileDialog.FileNames.ToArray();

                ClearTargetExecutableInfo();
                LoadTargetExecutableInfo(files[0]);

                return;
            }
        }
        
        private void CP_TextBoxModFolderLocation_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           { 
                if (CP_TextBoxModFolderLocation.Text.Any())
                {
                    ClearModFolder();
                    LoadModFolder(CP_TextBoxModFolderLocation.Text);
                }
           }
        }

        private void CP_ButtonRefreshFolderLocation_Click(object sender, EventArgs e)
        {
            bool ignoreRefresh = currentModFolderInfo.FullName != CP_TextBoxModFolderLocation.Text;
            if (ignoreRefresh)
            {
                ClearModFolder();
                LoadModFolder(CP_TextBoxModFolderLocation.Text);
            }
        }

        private void CP_ButtonModFolderFileDialog_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog modFolderFileDialog    = new CommonOpenFileDialog();
            modFolderFileDialog.Title                   = "Select your SRB2Kart Mod Folder.";
            modFolderFileDialog.IsFolderPicker          = true;
            modFolderFileDialog.AllowNonFileSystemItems = false;
            modFolderFileDialog.Multiselect             = false;
            modFolderFileDialog.AllowPropertyEditing    = true;
            modFolderFileDialog.EnsurePathExists        = true;

            if (modFolderFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else 
            {
                string[] directory = modFolderFileDialog.FileNames.ToArray();

                LoadModFolder(directory[0]);

                return;
            }
        }

        private void CP_ModFolderTreeView_AfterCheck(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (!enableTreeViewAfterCheck)
                return;

            // Checkmark/UnCheckmark all child nodes.
            void InternalRecursiveFunc(TreeNode nodeParent, bool isCheckmarked)
            {
                if (nodeParent.GetNodeCount(true) == 0)
                {
                    if (isCheckmarked)
                        currentSelectedModItems.TryAdd(nodeParent, nodeParent.Name);
                    else
                        currentSelectedModItems.Remove(nodeParent);
                }

                foreach (TreeNode childNode in nodeParent.Nodes)
                {
                    childNode.Checked = isCheckmarked;
                    InternalRecursiveFunc(childNode, isCheckmarked);
                }
            }

            TreeNode selectedNode           = e.Node;
            bool isSelectedNodeCheckmarked  = selectedNode.Checked;
            InternalRecursiveFunc(selectedNode, isSelectedNodeCheckmarked);
        }

        private void CP_ModFolderTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            HelpFunctionAlternateNodeColours(CP_ModFolderTreeView.Nodes);
        }
        private void CP_ModFolderTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            HelpFunctionAlternateNodeColours(CP_ModFolderTreeView.Nodes);
        }

        #endregion // End of region ~ Callbacks.

    }

}
