using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }

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

        #endregion // End of region ~ Implementation.

        #region Callbacks

        private void SP_ButtonNewConfig_Click(object sender, EventArgs e)
        {
            ConfigurationPanel newConfigurationPanel = new ConfigurationPanel();
            DisplayNewChildForm(newConfigurationPanel);

        }

        private void SP_ButtonEditConfig_Click(object sender, EventArgs e)
        {
            var targetExecutableFileDialog = new CommonOpenFileDialog();

            var configFileFilter    = new CommonFileDialogFilter("SRB2Kart Config", ".srb2k-config");
            var allFilter           = new CommonFileDialogFilter("All Files", "*.*");
            targetExecutableFileDialog.Filters.Add(configFileFilter);
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

                LoadConfigFile(files[0]);
            }
        }

        #endregion // End of regin=n ~ Callbacks.
    }
}
