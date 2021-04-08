using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Linq;
using System.IO;

namespace SRB2KModConfigurator
{
    public partial class ConfigurationPanel : Form
    {
        public ConfigurationPanel()
        {
            InitializeComponent();
        }

        private StarterPage parentPageRef;

        private DirectoryInfo currentModFolderInfo;
        private Dictionary<TreeNode, string> currentSelectedModItems;
        
        private void ConfigurationPanel_Load(object sender, EventArgs e)
        {
            parentPageRef           = (StarterPage)this.ParentForm;
            currentModFolderInfo    = null;
            currentSelectedModItems = new Dictionary<TreeNode, string>();

            // Tree View
            CP_ModFolderTreeView.CheckBoxes = true;

        }

        #region Implementation

        private void ClearModFolder()
        {
            currentModFolderInfo = null;
            currentSelectedModItems.Clear();
            CP_ModFolderTreeView.Nodes.Clear();
        }

        private bool LoadModFolder(string modFolderPathLocation)
        {
            DirectoryInfo newModFolderInfo = new DirectoryInfo(modFolderPathLocation);
            if (!newModFolderInfo.Exists)
            {
                // Error Message.
                return false;
            }

            if (currentModFolderInfo != null && currentModFolderInfo == newModFolderInfo)
            {
                // Ignore.
                return false;
            }

            currentModFolderInfo = newModFolderInfo;

            // Visual
            CP_TextBoxModFolderLocation.Text = modFolderPathLocation;

            // Order TreeView to load in data.
            FeedModFolderTreeViewer();

            return true;
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

        #endregion // End of region ~ Implementation.


        #region Callbacks
        private void CP_ButtonReturnStarterPage_Click(object sender, EventArgs e)
        {
            if (parentPageRef != null)
            {
                StarterPage starterPageRef = (StarterPage)this.ParentForm;
                starterPageRef.ShowStarterPageElements();
            }

            this.Close();
        }

        private void CP_TextBoxModFolderLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadModFolder(CP_TextBoxModFolderLocation.Text);
            }
        }

        private void CP_ButtonRefreshFolderLocation_Click(object sender, EventArgs e)
        {
            ClearModFolder();
            LoadModFolder(CP_TextBoxModFolderLocation.Text);
        }

        private void CP_ButtonModFolderFileDialog_Click(object sender, EventArgs e)
        {
            var modFolderFileDialog                     = new CommonOpenFileDialog();
            modFolderFileDialog.Title                   = "Select your SRB2Kart Mod Folder.";
            modFolderFileDialog.IsFolderPicker          = true;
            modFolderFileDialog.AllowNonFileSystemItems = false;
            modFolderFileDialog.Multiselect             = false;
            modFolderFileDialog.EnsurePathExists        = true;

            if (modFolderFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }
            else 
            { 
                string[] directory = modFolderFileDialog.FileNames.ToArray();

                LoadModFolder(directory[0]);            
            }
        }

        private void CP_ModFolderTreeView_AfterCheck(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
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
