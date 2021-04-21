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
    public partial class GeneralSettingsPanel : Form
    {
        public GeneralSettingsPanel()
        {
            InitializeComponent();
        }

        public GeneralSettingsDataStruct ReturnData()
        {
            GeneralSettingsDataStruct data = new GeneralSettingsDataStruct();

            return data;
        }
    }
}
