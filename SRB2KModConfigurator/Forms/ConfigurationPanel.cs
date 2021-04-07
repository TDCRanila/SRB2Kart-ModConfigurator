using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Linq;

namespace SRB2KModConfigurator
{
    public partial class ConfigurationPanel : Form
    {
        public ConfigurationPanel()
        {
            InitializeComponent();
        }

        private void CP_ModFolderTopTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CP_ButtonRefreshFolderLocation_Click(object sender, EventArgs e)
        {

        }

        private void CP_ButtonFileDialog_Click(object sender, EventArgs e)
        {
            var openFolder = new CommonOpenFileDialog();
            openFolder.AllowNonFileSystemItems = true;
            openFolder.Multiselect = true;
            openFolder.IsFolderPicker = true;
            openFolder.Title = "Select folders with jpg files";

            if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
            {
                MessageBox.Show("No Folder selected");
                return;
            }

            // get all the directories in selected dirctory
            var dirs = openFolder.FileNames.ToArray();
        }
    }
}
