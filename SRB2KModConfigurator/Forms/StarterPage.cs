using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Microsoft.WindowsAPICodePack.Dialogs;

using SRB2KModConfigurator.Config;

namespace SRB2KModConfigurator
{
    public partial class StarterPage : Form
    {
        private Form _activeChildForm = null;

        private SRB2ConfigFile selectedConfigFile;
        private string selectedConfigFilePath;
        private const string previousLaunchedConfigurationFileName = "last-used-configuration.txt";

        public StarterPage()
        {
            InitializeComponent();

            ClearStarterPageData();

            TryAndReadPreviousLaunchConfigurationSelection();
        }

        #region Helper

        private void ClearStarterPageData()
        {
            selectedConfigFile = null;
            selectedConfigFilePath = "";

            SP_TextBoxConfigurationSelect.Text = "No Configuration Selected";
        }

        private bool HelperLoadConfigFileDialog(ref string returnedFilePath)
        {
            CommonOpenFileDialog launchConfigurationFileDialog = new CommonOpenFileDialog();

            CommonFileDialogFilter configFileFilter = new CommonFileDialogFilter("SRB2Kart Config", ".srb2k-config");
            CommonFileDialogFilter allFilter = new CommonFileDialogFilter("All Files", "*.*");
            launchConfigurationFileDialog.Filters.Add(configFileFilter);
            launchConfigurationFileDialog.Filters.Add(allFilter);

            launchConfigurationFileDialog.Title = "Select your SRB2Kart Config.";
            launchConfigurationFileDialog.IsFolderPicker = false;
            launchConfigurationFileDialog.AllowNonFileSystemItems = false;
            launchConfigurationFileDialog.Multiselect = false;
            launchConfigurationFileDialog.AllowPropertyEditing = true;
            launchConfigurationFileDialog.EnsurePathExists = true;
            launchConfigurationFileDialog.Multiselect = false;

            if (launchConfigurationFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                returnedFilePath = "";
                return false;
            }
            else
            {
                string[] files = launchConfigurationFileDialog.FileNames.ToArray();
                returnedFilePath = files[0];
                return true;
            }
        }

        #endregion // End of region ~ Helper

        #region Implementation

        public void HideStarterPageElements()
        {
            SP_TableMainOptions.Visible = false;
            SP_TableLaunchOptions.Visible = false;
            SP_LabelTitle.Visible = false;
            SP_TableOrganisation.Visible = false;
        }

        public void ShowStarterPageElements()
        {
            SP_TableMainOptions.Visible = true;
            SP_TableLaunchOptions.Visible = true;
            SP_LabelTitle.Visible = true;
            SP_TableOrganisation.Visible = true;
        }

        public void RefreshStarterPage()
        {
            if (!TryAndReadPreviousLaunchConfigurationSelection())
            {
                ClearStarterPageData();
            }
        }

        private void DisplayNewChildForm(Form newChildForm)
        {
            // Close an already active form.
            if (_activeChildForm != null)
            {
                _activeChildForm.Close();
                _activeChildForm = null;
            }

            // Set new child form and the proper form settings.
            _activeChildForm = newChildForm;
            _activeChildForm.TopLevel = false;
            _activeChildForm.FormBorderStyle = FormBorderStyle.None;
            _activeChildForm.Dock = DockStyle.Fill;

            SP_ChildPanel.Controls.Clear();
            SP_ChildPanel.Controls.Add(_activeChildForm);
            SP_ChildPanel.Tag = _activeChildForm;
            SP_ChildPanel.Visible = true;

            _activeChildForm.BringToFront();

            HideStarterPageElements();
            _activeChildForm.Show();
        }

        private bool LoadAndEditConfigFile(string filePath)
        {
            FileInfo tempFileInfo = new FileInfo(filePath);
            if (!tempFileInfo.Exists)
            {
                return false;
            }

            // Read File.
            string returnedData = "";
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                if (fs.CanRead)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        returnedData = sr.ReadToEnd();
                    }
                }
            }

            if (returnedData == "")
            {
                ClearStarterPageData();
                return false;
            }

            // Load Config File
            selectedConfigFile = new SRB2ConfigFile();
            if (!selectedConfigFile.LoadFromJSONString(returnedData))
            {
                ClearStarterPageData();
                return false;
            }

            ConfigurationPanel newConfigurationPanel = new ConfigurationPanel(selectedConfigFile);
            DisplayNewChildForm(newConfigurationPanel);

            return true;
        }

        private bool SelectConfigFile(string filePath)
        {
            FileInfo tempFileInfo = new FileInfo(filePath);
            if (!tempFileInfo.Exists)
            {
                return false;
            }

            // Read File.
            string returnedData = "";
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                if (fs.CanRead)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        returnedData = sr.ReadToEnd();
                    }
                }
            }

            if (returnedData == "")
            {
                ClearStarterPageData();
                return false;
            }

            // Select & Load Config File
            selectedConfigFile = new SRB2ConfigFile();
            if (!selectedConfigFile.LoadFromJSONString(returnedData))
            {
                ClearStarterPageData();
                return false;
            }

            selectedConfigFilePath = filePath;

            // Visual
            SP_TextBoxConfigurationSelect.Text = new string(selectedConfigFile.configurationDisplayName + " - (" + selectedConfigFilePath + ")");

            return true;
        }

        private bool SavePreviousLaunchConfigurationSelection(string filePath)
        {
            Process process = Process.GetCurrentProcess();
            string fullPathOfProcess = process.MainModule.FileName;
            string dirOfProcess = fullPathOfProcess.Replace(process.MainModule.ModuleName, "");
            string fileName = previousLaunchedConfigurationFileName;
            string fullPath = (dirOfProcess + fileName);

            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                if (fs.CanWrite)
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(selectedConfigFilePath);
                    fs.Write(data);
                    return true;
                }
            }

            return false;
        }

        private bool TryAndReadPreviousLaunchConfigurationSelection()
        {
            Process process             = Process.GetCurrentProcess();
            string fullPathOfProcess    = process.MainModule.FileName;
            string dirOfProcess         = fullPathOfProcess.Replace(process.MainModule.ModuleName, "");
            string fileName             = previousLaunchedConfigurationFileName;
            string fullPath             = (dirOfProcess + fileName);

            FileInfo tempFileInfo = new FileInfo(fullPath);
            if (!tempFileInfo.Exists)
            {
                return false;
            }

            using (FileStream fs = new FileStream(fullPath, FileMode.Open))
            {
                if (fs.CanRead)
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        // Data in the file is the filepath already.
                        string returnedData = sr.ReadToEnd();
                        bool result = SelectConfigFile(returnedData);
                        return result;
                    }
                }
            }

            return false;
        }

        #endregion // End of region ~ Implementation.

        #region Callbacks

        private void SP_ButtonNewConfig_Click(object sender, EventArgs e)
        {
            ConfigurationPanel newConfigurationPanel = new ConfigurationPanel();
            DisplayNewChildForm(newConfigurationPanel);
        }

        private void SP_ButtonEditConfig_Click(object sender, EventArgs e)
        {
            string filePath = "";
            if (HelperLoadConfigFileDialog(ref filePath))
            {
                if (!LoadAndEditConfigFile(filePath))
                    MessageBox.Show("Failed to load configuration file for editing.", "Failed To Load Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SP_ButtonConfigurationSelect(object sender, EventArgs e)
        {
            string filePath = "";
            if (HelperLoadConfigFileDialog(ref filePath))
            {
                if (!SelectConfigFile(filePath))
                    MessageBox.Show("Failed to load & select configuration file.", "Failed To Load Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SP_ButtonLaunchConfig_Click(object sender, EventArgs e)
        {
            if (selectedConfigFile == null)
            {
                MessageBox.Show("Failed to launch game as there is no configuration selected.", "Failed To Launch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LauncherHelper.LaunchConfiguration(selectedConfigFile))
            {
                SavePreviousLaunchConfigurationSelection(selectedConfigFilePath);
                return;
            }
            else
            {
                MessageBox.Show("Couldn't open the game executable as an error occurred. ", "Failed To Launch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SP_LinkLabelCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/TDCRanila",
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }

        #endregion // End of region ~ Callbacks.

    }
}
