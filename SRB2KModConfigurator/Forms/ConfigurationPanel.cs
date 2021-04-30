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
        public ConfigurationPanel()
        {
            InitializeComponent();

            InitiliazeConfigurator();
        }

        public ConfigurationPanel(SRB2ConfigFile loadedConfigFile)
        {
            InitializeComponent();

            InitiliazeConfigurator();

            LoadModFolder(loadedConfigFile.mainModFolderPath);
            UpdateModFolderTreeViewer(loadedConfigFile.modFiles);
            LoadTargetExecutableInfo(loadedConfigFile.targetFilePath);

            generalSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.generalSettings);
            videoSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.videoSettings);
            audioSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.audioSettings);
            serverSettingsPanelRef.LoadData(loadedConfigFile.configSettingsData.serverSettings);
        }

        private StarterPage parentFormRef;

        private GeneralSettingsPanel generalSettingsPanelRef;
        private VideoSettingsPanel videoSettingsPanelRef;
        private AudioSettingsPanel audioSettingsPanelRef;
        private ServerSettingsPanel serverSettingsPanelRef;

        private DirectoryInfo currentModFolderInfo;
        private FileInfo currentTargetExecutableInfo;
        private Dictionary<TreeNode, string> currentSelectedModItems;
        private string currentTargetExecutable;
        private ConfigurationSettingsDataStruct configSettings;

        private bool isModFolderLocationValid;
        private bool isTargetExecutableLocationValid;
        private bool isConfigurationValid;

        private bool enableTreeViewAfterCheck ;

        private void InitiliazeConfigurator()
        {
            currentModFolderInfo        = null;
            currentSelectedModItems     = new Dictionary<TreeNode, string>();
            currentTargetExecutableInfo = null;
            currentTargetExecutable     = "";

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
            currentTargetExecutable     = "";
            SetTargetExecutableValidationStatus(false);
    }

        private void ClearModFolder()
        {
            currentModFolderInfo = null;
            currentSelectedModItems.Clear();
            CP_ModFolderTreeView.Nodes.Clear();
            SetModFolderValidationStatus(false);
        }

        private bool LoadTargetExecutableInfo(string targetExecutablePathLocation)
        {
            FileInfo newFileInfo = new FileInfo(targetExecutablePathLocation);
            if (!newFileInfo.Exists)
            {
                // Error Message.
                SetTargetExecutableValidationStatus(false);
                return false;
            }

            if (currentTargetExecutableInfo != null && currentTargetExecutableInfo == newFileInfo)
            {
                // Ignore.
                SetTargetExecutableValidationStatus(false);
                return false;
            }

            string textPath = targetExecutablePathLocation;
            bool isValidEntry   = textPath.Any() && textPath.Contains(".exe", StringComparison.InvariantCultureIgnoreCase);
            if (!isValidEntry)
            {
                // Error Message
                SetTargetExecutableValidationStatus(false);
                return false;
            }

            currentTargetExecutableInfo = newFileInfo;
            currentTargetExecutable     = targetExecutablePathLocation;

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
                return;
            }

            TreeNodeCollection treeViewNodeCollection =  CP_ModFolderTreeView.Nodes;
            // Find mods that were present in the modlist/configuration.
            foreach (string modPath in modList)
            {
                TreeNode[] foundNodes = treeViewNodeCollection.Find(modPath, true);
                if (foundNodes.Length <= 0)
                {
                    // Warning, tried to find item that was present in configuration, but can
                    //          no longer be found in the mod folder.
                    // Action , continue but just warn user.
                    continue;
                }

                if (foundNodes.Length >= 2)
                {
                    // Warning, multiple items found with same name.
                    // Action , continue and select both, but warn user.
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
            void InternalRecursiveFunc(TreeNode nodeParent)
            {
                bool isNodeAlternate = false;

                foreach (TreeNode childNode in nodeParent.Nodes)
                {
                    InternalRecursiveFunc(childNode);

                    if (isNodeAlternate)
                    {
                        isNodeAlternate = false;
                        childNode.BackColor = Color.FromArgb(255, 75, 75, 25);
                    }
                    else
                    {
                        isNodeAlternate = true;
                        childNode.BackColor = Color.FromArgb(255, 35, 35, 35);
                    }
                }
            }

            // Start Recursive Process.
            foreach (TreeNode nodeParent in nodeCollection)
            {
                InternalRecursiveFunc(nodeParent);
            }
        }

        private void SetTargetExecutableValidationStatus(bool isValid)
        {
            isTargetExecutableLocationValid = isValid;

            CheckConfigurationValiditity();

            if (isValid)
                CP_PictureBoxTargetExecutableValidation.Image = Properties.Resources.spr_checkmark;
            else
                CP_PictureBoxTargetExecutableValidation.Image = Properties.Resources.spr_crosss;
        }

        private void SetModFolderValidationStatus(bool isValid)
        {
            isModFolderLocationValid = isValid;

            CheckConfigurationValiditity();

            if (isValid)
                CP_PictureBoxModFolderValidation.Image = Properties.Resources.spr_checkmark;
            else
                CP_PictureBoxModFolderValidation.Image = Properties.Resources.spr_crosss;
        }

        private void CheckConfigurationValiditity()
        {
            isConfigurationValid = isTargetExecutableLocationValid && isModFolderLocationValid;

            CP_ButtonSaveConfiguration.Enabled      = isConfigurationValid;
            CP_ButtonExportConfigFileDialog.Enabled = isConfigurationValid;
        }

        #endregion // End of region ~ Implementation. - 

        #region Implementation - Exporting & Saving

        private void PrepareConfigurationData()
        {
            configSettings.generalSettings  = generalSettingsPanelRef.ReturnData();
            configSettings.videoSettings    = videoSettingsPanelRef.ReturnData();
            configSettings.audioSettings    = audioSettingsPanelRef.ReturnData();
            configSettings.serverSettings   = serverSettingsPanelRef.ReturnData();
        }

        private void SaveConfiguration()
        {
            // Collect Settings Data.
            PrepareConfigurationData();

            // Prepare File for Save Dialog.
            SRB2ConfigFile newConfigFile = new SRB2ConfigFile();
            newConfigFile.targetFilePath = currentTargetExecutable;
            newConfigFile.mainModFolderPath = currentModFolderInfo.ToString();
            foreach (string modItem in currentSelectedModItems.Values)
                newConfigFile.modFiles.Add(modItem);
            newConfigFile.configSettingsData = configSettings;

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
                string fileName             = configSaveFileDialog.FileName;
                FileStream fileStream       = File.Create(fileName);
                using (StreamWriter writer  = new StreamWriter(fileStream))
                {
                    FileInfo fileInfo = new FileInfo(fileName);

                    // Not that pretty way to update the underlying struct data.
                    generalSettingsPanelRef.GSP_TextBoxConfigName.Text = fileInfo.Name;
                    configSettings.generalSettings = generalSettingsPanelRef.ReturnData();
                    newConfigFile.configSettingsData = configSettings;

                    writer.Write(newConfigFile.CreateJSONString());
                }
                return;
            }
        }

        private void ExportConfiguration()
        {
            // Collect Settings Data.
            PrepareConfigurationData();

            // Prepare Config
            SRB2ConfigFile newConfigFile    = new SRB2ConfigFile();
            newConfigFile.targetFilePath    = currentTargetExecutable;
            newConfigFile.mainModFolderPath = currentModFolderInfo.ToString();
            foreach (string modItem in currentSelectedModItems.Values)
                newConfigFile.modFiles.Add(modItem);
            newConfigFile.configSettingsData = configSettings;

            // Save File & Dialog
            CommonSaveFileDialog configSaveFileDialog = new CommonSaveFileDialog();

            configSaveFileDialog.AlwaysAppendDefaultExtension = true;
            configSaveFileDialog.DefaultExtension = "bat";

            if (configSaveFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else
            {
                string fileName             = configSaveFileDialog.FileName;
                FileStream fileStream       = File.Create(fileName);
                using (StreamWriter writer  = new StreamWriter(fileStream))
                {
                    writer.Write(newConfigFile.CreateLauncherString());
                }
            }
        }

        #endregion

        #region Callbacks
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
            }

            this.Close();
        }

        private void CP_TextBoxTargetExecutableLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox     = CP_TextBoxTargetExecutableLocation;
                bool isValidEntry   = textBox.Text.Any() && textBox.Text.Contains(".exe", StringComparison.InvariantCultureIgnoreCase);
                SetTargetExecutableValidationStatus(isValidEntry);
            }
        }

        private void CP_ButtonRefreshTargetExecutable_Click(object sender, EventArgs e)
        {
            TextBox textBox     = CP_TextBoxTargetExecutableLocation;
            bool isValidEntry   = textBox.Text.Any() && textBox.Text.Contains(".exe", StringComparison.InvariantCultureIgnoreCase);
            SetTargetExecutableValidationStatus(isValidEntry);
        }

        private void CP_ButtonFileDialogTargetExecutable_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog targetExecutableFileDialog = new CommonOpenFileDialog();

            var exeFilter = new CommonFileDialogFilter("EXE Files", "*.exe");
            var allFilter = new CommonFileDialogFilter("All Files", "*.*");
            targetExecutableFileDialog.Filters.Add(exeFilter);
            targetExecutableFileDialog.Filters.Add(allFilter);
            
            targetExecutableFileDialog.Title = "Select your SRB2Kart EXE.";
            targetExecutableFileDialog.IsFolderPicker = false;
            targetExecutableFileDialog.AllowNonFileSystemItems = false;
            targetExecutableFileDialog.Multiselect = false;
            targetExecutableFileDialog.AllowPropertyEditing = true;
            targetExecutableFileDialog.EnsurePathExists = true;

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

        #endregion // End of region ~ Callbacks.
    }

}
