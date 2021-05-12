using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public StarterPage()
        {
            InitializeComponent();

            TryAndReadPreviousLaunchConfigurationSelection();
        }

        private SRB2ConfigFile selectedConfigFile;
        private string selectedConfigFilePath;

        #region Implementation

        public void HideStarterPageElements()
        {
            SP_TableMainOptions.Visible     = false;
            SP_TableLaunchOptions.Visible   = false;
            SP_LabelTitle.Visible           = false;
        }

        public void ShowStarterPageElements()
        {
            SP_TableMainOptions.Visible     = true;
            SP_TableLaunchOptions.Visible   = true;
            SP_LabelTitle.Visible           = true;
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
            _activeChildForm                    = newChildForm;
            _activeChildForm.TopLevel           = false;
            _activeChildForm.FormBorderStyle    = FormBorderStyle.None;
            _activeChildForm.Dock               = DockStyle.Fill;

            SP_ChildPanel.Controls.Clear();
            SP_ChildPanel.Controls.Add(_activeChildForm);
            SP_ChildPanel.Tag = _activeChildForm;
            SP_ChildPanel.Visible = true;

            _activeChildForm.BringToFront();

            HideStarterPageElements();
            _activeChildForm.Show();
            
        }

        private void LoadConfigFile(string filePath)
        {
            // Read File.
            string configFileString = "";
            var fileStream          = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                configFileString = reader.ReadToEnd();
            }

            // Load Config File
            SRB2ConfigFile configFile = new SRB2ConfigFile();
            configFile.LoadFromJSONString(configFileString);

            ConfigurationPanel newConfigurationPanel = new ConfigurationPanel(configFile);
            DisplayNewChildForm(newConfigurationPanel);
        }

        private void SelectConfigFile(string filePath)
        {
            // Read File.
            string configFileString = "";
            var fileStream          = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                configFileString = reader.ReadToEnd();
            }

            // Select & Load Config File
            selectedConfigFile = new SRB2ConfigFile();
            selectedConfigFile.LoadFromJSONString(configFileString);
            selectedConfigFilePath = filePath;

            // Visual
            SP_TextBoxConfigurationSelect.Text = new string(selectedConfigFile.configurationDisplayName + " - (" + selectedConfigFilePath + ")");
        }

        private void SavePreviousLaunchConfigurationSelection(string filePath)
        {
            Process process             = Process.GetCurrentProcess();
            string fullPathOfProcess    = process.MainModule.FileName;
            string dirOfProcess         = fullPathOfProcess.Replace(process.MainModule.ModuleName, "");
            string fileName             = "last-used-configuration.txt";
            string fullPath             = (dirOfProcess + fileName);

            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                byte[] data = new UTF8Encoding(true).GetBytes(selectedConfigFilePath);
                fs.Write(data);
            }
        }

        private bool TryAndReadPreviousLaunchConfigurationSelection()
        {
            Process process = Process.GetCurrentProcess();
            string fullPathOfProcess = process.MainModule.FileName;
            string dirOfProcess = fullPathOfProcess.Replace(process.MainModule.ModuleName, "");
            string fileName = "last-used-configuration.txt";
            string fullPath = (dirOfProcess + fileName);

            FileInfo tempFileInfo = new FileInfo(fullPath);
            if (!tempFileInfo.Exists)
            {
                return false;
            }

            string returnedData;
            using (FileStream fs = new FileStream(fullPath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    returnedData = sr.ReadToEnd();
                }
            }

            FileInfo fileInfo = new FileInfo(returnedData);
            if (fileInfo.Exists)
            {
                SelectConfigFile(returnedData);
                return true;
            }
            else
            {
                return false;
            }
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
            var editConfigurationFileDialog = new CommonOpenFileDialog();

            var configFileFilter    = new CommonFileDialogFilter("SRB2Kart Config", ".srb2k-config");
            var allFilter           = new CommonFileDialogFilter("All Files", "*.*");
            editConfigurationFileDialog.Filters.Add(configFileFilter);
            editConfigurationFileDialog.Filters.Add(allFilter);

            editConfigurationFileDialog.Title                    = "Select your SRB2Kart EXE.";
            editConfigurationFileDialog.IsFolderPicker           = false;
            editConfigurationFileDialog.AllowNonFileSystemItems  = false;
            editConfigurationFileDialog.Multiselect              = false;
            editConfigurationFileDialog.AllowPropertyEditing     = true;
            editConfigurationFileDialog.EnsurePathExists         = true;
            editConfigurationFileDialog.Multiselect              = false;

            if (editConfigurationFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else
            {
                string[] files = editConfigurationFileDialog.FileNames.ToArray();

                LoadConfigFile(files[0]);
            }
        }

        private void SP_ButtonLaunchFileDialog_Click(object sender, EventArgs e)
        {
            var launchConfigurationFileDialog = new CommonOpenFileDialog();

            var configFileFilter    = new CommonFileDialogFilter("SRB2Kart Config", ".srb2k-config");
            var allFilter           = new CommonFileDialogFilter("All Files", "*.*");
            launchConfigurationFileDialog.Filters.Add(configFileFilter);
            launchConfigurationFileDialog.Filters.Add(allFilter);

            launchConfigurationFileDialog.Title                    = "Select your SRB2Kart EXE.";
            launchConfigurationFileDialog.IsFolderPicker           = false;
            launchConfigurationFileDialog.AllowNonFileSystemItems  = false;
            launchConfigurationFileDialog.Multiselect              = false;
            launchConfigurationFileDialog.AllowPropertyEditing     = true;
            launchConfigurationFileDialog.EnsurePathExists         = true;
            launchConfigurationFileDialog.Multiselect              = false;

            if (launchConfigurationFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else
            {
                string[] files = launchConfigurationFileDialog.FileNames.ToArray();

                SelectConfigFile(files[0]);
            }
        }

        private void SP_ButtonLaunchConfig_Click(object sender, EventArgs e)
        {
            if (LauncherHelper.LaunchConfiguration(selectedConfigFile))
            {
                SavePreviousLaunchConfigurationSelection(selectedConfigFilePath);
            }
        }

        #endregion // End of regin=n ~ Callbacks.

    }
}
