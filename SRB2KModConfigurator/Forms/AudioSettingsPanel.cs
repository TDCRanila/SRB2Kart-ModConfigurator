using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SRB2KModConfigurator.Data;

namespace SRB2KModConfigurator.Forms
{
    public partial class AudioSettingsPanel : Form
    {
        public AudioSettingsPanel()
        {
            InitializeComponent();
        }

        public void LoadData(AudioSettingsDataStruct data)
        {
            ASP_CheckBoxMusic.Checked   = data.disableMusic;
            ASP_CheckBoxSFXs.Checked    = data.disableSFXs;
        }

        public AudioSettingsDataStruct ReturnData()
        {
            AudioSettingsDataStruct data = new AudioSettingsDataStruct();

            data.disableMusic   = ASP_CheckBoxMusic.Checked;
            data.disableSFXs    = ASP_CheckBoxSFXs.Checked;

            return data;
        }
    }
}
