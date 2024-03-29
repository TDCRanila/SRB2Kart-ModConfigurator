﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;


using Microsoft.WindowsAPICodePack.Dialogs;

using SRB2KModConfigurator.Data;

namespace SRB2KModConfigurator.Forms
{
    public partial class GeneralSettingsPanel : Form
    {
        public GeneralSettingsPanel()
        {
            InitializeComponent();

            InitializeSettingsControls();
        }

        private FileInfo currentCustomConfigFileInfo;
        private string currentCustomConfigFilePath;

        private void InitializeSettingsControls()
        {
            GSP_ComboBoxDataActions.Items.Clear();
            GSP_ComboBoxDataActions.Items.AddRange(Enum.GetNames(typeof(DataAction)));

            GSP_ComboBoxDataActions.SelectedIndex = 0;
        }

        public void LoadData(GeneralSettingsDataStruct data)
        {
            GSP_CheckboxBonusCharacters.Checked     = data.shouldAddBonusCharacterPack;
            GSP_CheckBoxSkipGameIntro.Checked       = data.shouldSkipGameIntro;
            GSP_ComboBoxDataActions.SelectedIndex   = (int)data.dataAction;
            GSP_CheckBoxAdditionalConsole.Checked   = data.enableAdditionalConsole;
            currentCustomConfigFilePath             = data.customConfigFilePath;
            GSP_TextBoxAdditionalParameters.Text    = data.additionalCommandlineParameters;
        }

        public GeneralSettingsDataStruct ReturnData()
        {
            GeneralSettingsDataStruct data = new GeneralSettingsDataStruct();

            data.shouldAddBonusCharacterPack        = GSP_CheckboxBonusCharacters.Enabled && GSP_CheckboxBonusCharacters.Checked ;
            data.shouldSkipGameIntro                = GSP_CheckBoxSkipGameIntro.Checked;
            data.dataAction                         = (DataAction)Enum.Parse(typeof(DataAction), GSP_ComboBoxDataActions.SelectedItem.ToString());
            data.enableAdditionalConsole            = GSP_CheckBoxAdditionalConsole.Checked;
            data.customConfigFilePath               = currentCustomConfigFilePath;
            data.additionalCommandlineParameters    = (GSP_TextBoxAdditionalParameters.Text).TrimEnd();

            return data;
        }

        public void EnableBonusCharacterPackOption()
        {
            GSP_CheckboxBonusCharacters.Enabled = true;
            GSP_LabelBonusCharacter.ForeColor   = Color.White;
        }

        public void DisableBonusCharacterPackOption()
        {
            GSP_CheckboxBonusCharacters.Enabled = false;
            GSP_LabelBonusCharacter.ForeColor   = Color.Red;
        }

        #region Callbacks

        private void GSP_ButtonCustomConfigFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog targetExecutableFileDialog = new CommonOpenFileDialog();

            var cfgFilter = new CommonFileDialogFilter("CONFIG Files", "*.cfg");
            var allFilter = new CommonFileDialogFilter("All Files", "*.*");
            targetExecutableFileDialog.Filters.Add(cfgFilter);
            targetExecutableFileDialog.Filters.Add(allFilter);

            targetExecutableFileDialog.Title                    = "Select your Custom Config File.";
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

                currentCustomConfigFilePath = files[0];
                currentCustomConfigFileInfo = new FileInfo(currentCustomConfigFilePath);

                GSP_TextBoxCustomConfigFile.Text = currentCustomConfigFilePath;

                string textPath = currentCustomConfigFilePath;
                bool isValidEntry = textPath.Any() && textPath.Contains(".cfg", StringComparison.InvariantCultureIgnoreCase);
                if (!isValidEntry)
                {
                    // Warning Message
                    // POP UP : Regarding extension (cfg)
                    MessageBox.Show("The selected File doesn't have the '.cfg' extension and might not be compatible.", 
                        "Potential Incomptabile File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return;
            }
        }

        private void GSP_TextBoxCustomConfigFile_TextChanged(object sender, EventArgs e)
        {
            GSP_TextBoxCustomConfigFile.Text = (GSP_TextBoxCustomConfigFile.Text).TrimStart();
        }

        private void GSP_TextBoxAdditionalParameters_TextChanged(object sender, EventArgs e)
        {
            GSP_TextBoxAdditionalParameters.Text = (GSP_TextBoxAdditionalParameters.Text).TrimStart();
        }

        #endregion // End of region ~ Callbacks.

    }
}
