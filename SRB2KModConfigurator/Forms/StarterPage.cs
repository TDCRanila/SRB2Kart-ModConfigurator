using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SRB2KModConfigurator
{
    public partial class StarterPage : Form
    {
        private Form _activeChildForm = null;

        public StarterPage()
        {
            InitializeComponent();
        }
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

        private void SP_ButtonNewConfig_Click(object sender, EventArgs e)
        {
            ConfigurationPanel newConfigurationPanel = new ConfigurationPanel();
            DisplayNewChildForm(newConfigurationPanel);

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

    }
}
