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
    public partial class VideoSettingsPanel : Form
    {
        public VideoSettingsPanel()
        {
            InitializeComponent();
        }

        public VideoSettingsDataStruct ReturnData()
        {
            VideoSettingsDataStruct data = new VideoSettingsDataStruct();

            return data;
        }
    }
}
