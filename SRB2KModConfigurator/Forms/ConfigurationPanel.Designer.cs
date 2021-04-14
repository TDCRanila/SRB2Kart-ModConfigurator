
namespace SRB2KModConfigurator
{
    partial class ConfigurationPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CP_MainPanel = new System.Windows.Forms.Panel();
            this.CP_ModFolderTable = new System.Windows.Forms.TableLayoutPanel();
            this.CP_FolderListPanel = new System.Windows.Forms.Panel();
            this.CP_ModFolderTreeView = new System.Windows.Forms.TreeView();
            this.CP_SettingsView = new System.Windows.Forms.Panel();
            this.CP_TableSettings = new System.Windows.Forms.TableLayoutPanel();
            this.CP_NiceGroupGameParameters = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_NiceGroupServerSettings = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_NiceGroupLauncherSettings = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_NiceGroupModFolderSettings = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_TableModFolderSettings = new System.Windows.Forms.TableLayoutPanel();
            this.CP_PictureBoxModFolderValidation = new System.Windows.Forms.PictureBox();
            this.CP_TextBoxModFolderLocation = new System.Windows.Forms.TextBox();
            this.CP_ButtonModFolderFileDialog = new System.Windows.Forms.Button();
            this.CP_ButtonRefreshModFolderLocation = new System.Windows.Forms.Button();
            this.CP_TableTopBar = new System.Windows.Forms.TableLayoutPanel();
            this.CP_TableTopBarTools = new System.Windows.Forms.TableLayoutPanel();
            this.CP_ButtonSaveConfiguration = new System.Windows.Forms.Button();
            this.CP_ButtonExportConfigFileDialog = new System.Windows.Forms.Button();
            this.CP_ButtonReturnStarterPage = new System.Windows.Forms.Button();
            this.CP_NiceGroupTargetExecutable = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_TableTargetExecutable = new System.Windows.Forms.TableLayoutPanel();
            this.CP_PictureBoxTargetExecutableValidation = new System.Windows.Forms.PictureBox();
            this.CP_TextBoxTargetExecutableLocation = new System.Windows.Forms.TextBox();
            this.CP_ButtonFileDialogTargetExecutable = new System.Windows.Forms.Button();
            this.CP_ButtonRefreshTargetExecutable = new System.Windows.Forms.Button();
            this.CP_MainPanel.SuspendLayout();
            this.CP_ModFolderTable.SuspendLayout();
            this.CP_FolderListPanel.SuspendLayout();
            this.CP_SettingsView.SuspendLayout();
            this.CP_TableSettings.SuspendLayout();
            this.CP_NiceGroupModFolderSettings.SuspendLayout();
            this.CP_TableModFolderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_PictureBoxModFolderValidation)).BeginInit();
            this.CP_TableTopBar.SuspendLayout();
            this.CP_TableTopBarTools.SuspendLayout();
            this.CP_NiceGroupTargetExecutable.SuspendLayout();
            this.CP_TableTargetExecutable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_PictureBoxTargetExecutableValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // CP_MainPanel
            // 
            this.CP_MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_MainPanel.Controls.Add(this.CP_ModFolderTable);
            this.CP_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.CP_MainPanel.Name = "CP_MainPanel";
            this.CP_MainPanel.Size = new System.Drawing.Size(1264, 681);
            this.CP_MainPanel.TabIndex = 0;
            // 
            // CP_ModFolderTable
            // 
            this.CP_ModFolderTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.CP_ModFolderTable.ColumnCount = 2;
            this.CP_ModFolderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.72982F));
            this.CP_ModFolderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.27018F));
            this.CP_ModFolderTable.Controls.Add(this.CP_FolderListPanel, 0, 1);
            this.CP_ModFolderTable.Controls.Add(this.CP_SettingsView, 1, 1);
            this.CP_ModFolderTable.Controls.Add(this.CP_NiceGroupModFolderSettings, 0, 0);
            this.CP_ModFolderTable.Controls.Add(this.CP_TableTopBar, 1, 0);
            this.CP_ModFolderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ModFolderTable.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CP_ModFolderTable.Location = new System.Drawing.Point(0, 0);
            this.CP_ModFolderTable.Margin = new System.Windows.Forms.Padding(1);
            this.CP_ModFolderTable.Name = "CP_ModFolderTable";
            this.CP_ModFolderTable.Padding = new System.Windows.Forms.Padding(5);
            this.CP_ModFolderTable.RowCount = 2;
            this.CP_ModFolderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.682634F));
            this.CP_ModFolderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.31737F));
            this.CP_ModFolderTable.Size = new System.Drawing.Size(1264, 681);
            this.CP_ModFolderTable.TabIndex = 0;
            // 
            // CP_FolderListPanel
            // 
            this.CP_FolderListPanel.Controls.Add(this.CP_ModFolderTreeView);
            this.CP_FolderListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_FolderListPanel.Location = new System.Drawing.Point(11, 71);
            this.CP_FolderListPanel.Name = "CP_FolderListPanel";
            this.CP_FolderListPanel.Padding = new System.Windows.Forms.Padding(4);
            this.CP_FolderListPanel.Size = new System.Drawing.Size(463, 599);
            this.CP_FolderListPanel.TabIndex = 0;
            // 
            // CP_ModFolderTreeView
            // 
            this.CP_ModFolderTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CP_ModFolderTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_ModFolderTreeView.CheckBoxes = true;
            this.CP_ModFolderTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ModFolderTreeView.Font = new System.Drawing.Font("envypn7x15", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ModFolderTreeView.ForeColor = System.Drawing.Color.White;
            this.CP_ModFolderTreeView.LineColor = System.Drawing.Color.White;
            this.CP_ModFolderTreeView.Location = new System.Drawing.Point(4, 4);
            this.CP_ModFolderTreeView.Name = "CP_ModFolderTreeView";
            this.CP_ModFolderTreeView.Size = new System.Drawing.Size(455, 591);
            this.CP_ModFolderTreeView.TabIndex = 0;
            this.CP_ModFolderTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.CP_ModFolderTreeView_AfterCheck);
            // 
            // CP_SettingsView
            // 
            this.CP_SettingsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_SettingsView.AutoScroll = true;
            this.CP_SettingsView.Controls.Add(this.CP_TableSettings);
            this.CP_SettingsView.Location = new System.Drawing.Point(483, 71);
            this.CP_SettingsView.Name = "CP_SettingsView";
            this.CP_SettingsView.Size = new System.Drawing.Size(770, 591);
            this.CP_SettingsView.TabIndex = 1;
            // 
            // CP_TableSettings
            // 
            this.CP_TableSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CP_TableSettings.ColumnCount = 1;
            this.CP_TableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.51724F));
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupGameParameters, 0, 2);
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupServerSettings, 0, 1);
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupLauncherSettings, 0, 0);
            this.CP_TableSettings.Location = new System.Drawing.Point(0, 0);
            this.CP_TableSettings.Name = "CP_TableSettings";
            this.CP_TableSettings.Padding = new System.Windows.Forms.Padding(4);
            this.CP_TableSettings.RowCount = 3;
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CP_TableSettings.Size = new System.Drawing.Size(752, 772);
            this.CP_TableSettings.TabIndex = 0;
            // 
            // CP_NiceGroupGameParameters
            // 
            this.CP_NiceGroupGameParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupGameParameters.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupGameParameters.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupGameParameters.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupGameParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupGameParameters.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupGameParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupGameParameters.Location = new System.Drawing.Point(7, 422);
            this.CP_NiceGroupGameParameters.MinimumSize = new System.Drawing.Size(100, 100);
            this.CP_NiceGroupGameParameters.Name = "CP_NiceGroupGameParameters";
            this.CP_NiceGroupGameParameters.Size = new System.Drawing.Size(738, 343);
            this.CP_NiceGroupGameParameters.TabIndex = 2;
            this.CP_NiceGroupGameParameters.TabStop = false;
            this.CP_NiceGroupGameParameters.Text = "Launcher Settings";
            // 
            // CP_NiceGroupServerSettings
            // 
            this.CP_NiceGroupServerSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupServerSettings.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupServerSettings.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupServerSettings.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupServerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupServerSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupServerSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupServerSettings.Location = new System.Drawing.Point(7, 174);
            this.CP_NiceGroupServerSettings.MinimumSize = new System.Drawing.Size(100, 100);
            this.CP_NiceGroupServerSettings.Name = "CP_NiceGroupServerSettings";
            this.CP_NiceGroupServerSettings.Size = new System.Drawing.Size(738, 242);
            this.CP_NiceGroupServerSettings.TabIndex = 1;
            this.CP_NiceGroupServerSettings.TabStop = false;
            this.CP_NiceGroupServerSettings.Text = "Launcher Settings";
            // 
            // CP_NiceGroupLauncherSettings
            // 
            this.CP_NiceGroupLauncherSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupLauncherSettings.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupLauncherSettings.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupLauncherSettings.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupLauncherSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupLauncherSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupLauncherSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupLauncherSettings.Location = new System.Drawing.Point(7, 7);
            this.CP_NiceGroupLauncherSettings.MinimumSize = new System.Drawing.Size(100, 100);
            this.CP_NiceGroupLauncherSettings.Name = "CP_NiceGroupLauncherSettings";
            this.CP_NiceGroupLauncherSettings.Size = new System.Drawing.Size(738, 161);
            this.CP_NiceGroupLauncherSettings.TabIndex = 0;
            this.CP_NiceGroupLauncherSettings.TabStop = false;
            this.CP_NiceGroupLauncherSettings.Text = "Launcher Settings";
            // 
            // CP_NiceGroupModFolderSettings
            // 
            this.CP_NiceGroupModFolderSettings.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupModFolderSettings.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupModFolderSettings.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupModFolderSettings.Controls.Add(this.CP_TableModFolderSettings);
            this.CP_NiceGroupModFolderSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupModFolderSettings.Font = new System.Drawing.Font("envypn7x15", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupModFolderSettings.ForeColor = System.Drawing.Color.White;
            this.CP_NiceGroupModFolderSettings.Location = new System.Drawing.Point(11, 11);
            this.CP_NiceGroupModFolderSettings.Name = "CP_NiceGroupModFolderSettings";
            this.CP_NiceGroupModFolderSettings.Size = new System.Drawing.Size(463, 51);
            this.CP_NiceGroupModFolderSettings.TabIndex = 4;
            this.CP_NiceGroupModFolderSettings.TabStop = false;
            this.CP_NiceGroupModFolderSettings.Text = "Mod Folder";
            // 
            // CP_TableModFolderSettings
            // 
            this.CP_TableModFolderSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_TableModFolderSettings.BackColor = System.Drawing.Color.Transparent;
            this.CP_TableModFolderSettings.ColumnCount = 4;
            this.CP_TableModFolderSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.CP_TableModFolderSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableModFolderSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.CP_TableModFolderSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.CP_TableModFolderSettings.Controls.Add(this.CP_PictureBoxModFolderValidation, 1, 0);
            this.CP_TableModFolderSettings.Controls.Add(this.CP_TextBoxModFolderLocation, 0, 0);
            this.CP_TableModFolderSettings.Controls.Add(this.CP_ButtonModFolderFileDialog, 3, 0);
            this.CP_TableModFolderSettings.Controls.Add(this.CP_ButtonRefreshModFolderLocation, 2, 0);
            this.CP_TableModFolderSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_TableModFolderSettings.ForeColor = System.Drawing.Color.Transparent;
            this.CP_TableModFolderSettings.Location = new System.Drawing.Point(6, 7);
            this.CP_TableModFolderSettings.Margin = new System.Windows.Forms.Padding(0);
            this.CP_TableModFolderSettings.Name = "CP_TableModFolderSettings";
            this.CP_TableModFolderSettings.RowCount = 1;
            this.CP_TableModFolderSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableModFolderSettings.Size = new System.Drawing.Size(451, 42);
            this.CP_TableModFolderSettings.TabIndex = 0;
            // 
            // CP_PictureBoxModFolderValidation
            // 
            this.CP_PictureBoxModFolderValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_PictureBoxModFolderValidation.BackColor = System.Drawing.Color.Transparent;
            this.CP_PictureBoxModFolderValidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CP_PictureBoxModFolderValidation.Image = global::SRB2KModConfigurator.Properties.Resources.spr_checkmark;
            this.CP_PictureBoxModFolderValidation.Location = new System.Drawing.Point(331, 9);
            this.CP_PictureBoxModFolderValidation.Name = "CP_PictureBoxModFolderValidation";
            this.CP_PictureBoxModFolderValidation.Size = new System.Drawing.Size(23, 24);
            this.CP_PictureBoxModFolderValidation.TabIndex = 1;
            this.CP_PictureBoxModFolderValidation.TabStop = false;
            // 
            // CP_TextBoxModFolderLocation
            // 
            this.CP_TextBoxModFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_TextBoxModFolderLocation.Location = new System.Drawing.Point(3, 10);
            this.CP_TextBoxModFolderLocation.Name = "CP_TextBoxModFolderLocation";
            this.CP_TextBoxModFolderLocation.Size = new System.Drawing.Size(322, 22);
            this.CP_TextBoxModFolderLocation.TabIndex = 0;
            this.CP_TextBoxModFolderLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CP_TextBoxModFolderLocation_KeyDown);
            // 
            // CP_ButtonModFolderFileDialog
            // 
            this.CP_ButtonModFolderFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonModFolderFileDialog.Location = new System.Drawing.Point(407, 9);
            this.CP_ButtonModFolderFileDialog.Name = "CP_ButtonModFolderFileDialog";
            this.CP_ButtonModFolderFileDialog.Size = new System.Drawing.Size(41, 24);
            this.CP_ButtonModFolderFileDialog.TabIndex = 2;
            this.CP_ButtonModFolderFileDialog.Text = "F";
            this.CP_ButtonModFolderFileDialog.UseVisualStyleBackColor = true;
            this.CP_ButtonModFolderFileDialog.Click += new System.EventHandler(this.CP_ButtonModFolderFileDialog_Click);
            // 
            // CP_ButtonRefreshModFolderLocation
            // 
            this.CP_ButtonRefreshModFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonRefreshModFolderLocation.Location = new System.Drawing.Point(360, 9);
            this.CP_ButtonRefreshModFolderLocation.Name = "CP_ButtonRefreshModFolderLocation";
            this.CP_ButtonRefreshModFolderLocation.Size = new System.Drawing.Size(41, 24);
            this.CP_ButtonRefreshModFolderLocation.TabIndex = 1;
            this.CP_ButtonRefreshModFolderLocation.Text = "R";
            this.CP_ButtonRefreshModFolderLocation.UseVisualStyleBackColor = true;
            this.CP_ButtonRefreshModFolderLocation.Click += new System.EventHandler(this.CP_ButtonRefreshFolderLocation_Click);
            // 
            // CP_TableTopBar
            // 
            this.CP_TableTopBar.ColumnCount = 3;
            this.CP_TableTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.059603F));
            this.CP_TableTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.9404F));
            this.CP_TableTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.CP_TableTopBar.Controls.Add(this.CP_TableTopBarTools, 2, 0);
            this.CP_TableTopBar.Controls.Add(this.CP_NiceGroupTargetExecutable, 1, 0);
            this.CP_TableTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_TableTopBar.Location = new System.Drawing.Point(480, 8);
            this.CP_TableTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.CP_TableTopBar.Name = "CP_TableTopBar";
            this.CP_TableTopBar.RowCount = 1;
            this.CP_TableTopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTopBar.Size = new System.Drawing.Size(776, 57);
            this.CP_TableTopBar.TabIndex = 5;
            // 
            // CP_TableTopBarTools
            // 
            this.CP_TableTopBarTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_TableTopBarTools.ColumnCount = 3;
            this.CP_TableTopBarTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTopBarTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTopBarTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.CP_TableTopBarTools.Controls.Add(this.CP_ButtonSaveConfiguration, 0, 0);
            this.CP_TableTopBarTools.Controls.Add(this.CP_ButtonExportConfigFileDialog, 1, 0);
            this.CP_TableTopBarTools.Controls.Add(this.CP_ButtonReturnStarterPage, 2, 0);
            this.CP_TableTopBarTools.Location = new System.Drawing.Point(587, 6);
            this.CP_TableTopBarTools.Name = "CP_TableTopBarTools";
            this.CP_TableTopBarTools.RowCount = 1;
            this.CP_TableTopBarTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTopBarTools.Size = new System.Drawing.Size(186, 44);
            this.CP_TableTopBarTools.TabIndex = 1;
            // 
            // CP_ButtonSaveConfiguration
            // 
            this.CP_ButtonSaveConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ButtonSaveConfiguration.Location = new System.Drawing.Point(3, 3);
            this.CP_ButtonSaveConfiguration.Name = "CP_ButtonSaveConfiguration";
            this.CP_ButtonSaveConfiguration.Size = new System.Drawing.Size(56, 38);
            this.CP_ButtonSaveConfiguration.TabIndex = 0;
            this.CP_ButtonSaveConfiguration.Text = "Save";
            this.CP_ButtonSaveConfiguration.UseVisualStyleBackColor = true;
            this.CP_ButtonSaveConfiguration.Click += new System.EventHandler(this.CP_ButtonSaveConfiguration_Click);
            // 
            // CP_ButtonExportConfigFileDialog
            // 
            this.CP_ButtonExportConfigFileDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ButtonExportConfigFileDialog.Location = new System.Drawing.Point(65, 3);
            this.CP_ButtonExportConfigFileDialog.Name = "CP_ButtonExportConfigFileDialog";
            this.CP_ButtonExportConfigFileDialog.Size = new System.Drawing.Size(56, 38);
            this.CP_ButtonExportConfigFileDialog.TabIndex = 1;
            this.CP_ButtonExportConfigFileDialog.Text = "Export";
            this.CP_ButtonExportConfigFileDialog.UseVisualStyleBackColor = true;
            this.CP_ButtonExportConfigFileDialog.Click += new System.EventHandler(this.CP_ButtonExportConfigFileDialog_Click);
            // 
            // CP_ButtonReturnStarterPage
            // 
            this.CP_ButtonReturnStarterPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ButtonReturnStarterPage.Location = new System.Drawing.Point(127, 3);
            this.CP_ButtonReturnStarterPage.Name = "CP_ButtonReturnStarterPage";
            this.CP_ButtonReturnStarterPage.Size = new System.Drawing.Size(56, 38);
            this.CP_ButtonReturnStarterPage.TabIndex = 2;
            this.CP_ButtonReturnStarterPage.Text = "Return";
            this.CP_ButtonReturnStarterPage.UseVisualStyleBackColor = true;
            this.CP_ButtonReturnStarterPage.Click += new System.EventHandler(this.CP_ButtonReturnStarterPage_Click);
            // 
            // CP_NiceGroupTargetExecutable
            // 
            this.CP_NiceGroupTargetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_NiceGroupTargetExecutable.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupTargetExecutable.BorderRectangleHeightOffset = 1;
            this.CP_NiceGroupTargetExecutable.BorderRectangleWidthOffset = 5;
            this.CP_NiceGroupTargetExecutable.Controls.Add(this.CP_TableTargetExecutable);
            this.CP_NiceGroupTargetExecutable.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupTargetExecutable.ForeColor = System.Drawing.Color.White;
            this.CP_NiceGroupTargetExecutable.Location = new System.Drawing.Point(9, 3);
            this.CP_NiceGroupTargetExecutable.Name = "CP_NiceGroupTargetExecutable";
            this.CP_NiceGroupTargetExecutable.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.CP_NiceGroupTargetExecutable.Size = new System.Drawing.Size(572, 51);
            this.CP_NiceGroupTargetExecutable.TabIndex = 0;
            this.CP_NiceGroupTargetExecutable.TabStop = false;
            this.CP_NiceGroupTargetExecutable.Text = "Target Executable";
            // 
            // CP_TableTargetExecutable
            // 
            this.CP_TableTargetExecutable.BackColor = System.Drawing.Color.Transparent;
            this.CP_TableTargetExecutable.ColumnCount = 4;
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CP_TableTargetExecutable.Controls.Add(this.CP_PictureBoxTargetExecutableValidation, 0, 0);
            this.CP_TableTargetExecutable.Controls.Add(this.CP_TextBoxTargetExecutableLocation, 0, 0);
            this.CP_TableTargetExecutable.Controls.Add(this.CP_ButtonFileDialogTargetExecutable, 3, 0);
            this.CP_TableTargetExecutable.Controls.Add(this.CP_ButtonRefreshTargetExecutable, 2, 0);
            this.CP_TableTargetExecutable.Location = new System.Drawing.Point(3, 7);
            this.CP_TableTargetExecutable.Name = "CP_TableTargetExecutable";
            this.CP_TableTargetExecutable.Padding = new System.Windows.Forms.Padding(2, 0, 2, 1);
            this.CP_TableTargetExecutable.RowCount = 1;
            this.CP_TableTargetExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTargetExecutable.Size = new System.Drawing.Size(565, 44);
            this.CP_TableTargetExecutable.TabIndex = 0;
            // 
            // CP_PictureBoxTargetExecutableValidation
            // 
            this.CP_PictureBoxTargetExecutableValidation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CP_PictureBoxTargetExecutableValidation.BackColor = System.Drawing.Color.Transparent;
            this.CP_PictureBoxTargetExecutableValidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CP_PictureBoxTargetExecutableValidation.Image = global::SRB2KModConfigurator.Properties.Resources.spr_checkmark;
            this.CP_PictureBoxTargetExecutableValidation.Location = new System.Drawing.Point(439, 9);
            this.CP_PictureBoxTargetExecutableValidation.Name = "CP_PictureBoxTargetExecutableValidation";
            this.CP_PictureBoxTargetExecutableValidation.Size = new System.Drawing.Size(24, 24);
            this.CP_PictureBoxTargetExecutableValidation.TabIndex = 4;
            this.CP_PictureBoxTargetExecutableValidation.TabStop = false;
            // 
            // CP_TextBoxTargetExecutableLocation
            // 
            this.CP_TextBoxTargetExecutableLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_TextBoxTargetExecutableLocation.Location = new System.Drawing.Point(6, 10);
            this.CP_TextBoxTargetExecutableLocation.Margin = new System.Windows.Forms.Padding(4);
            this.CP_TextBoxTargetExecutableLocation.Name = "CP_TextBoxTargetExecutableLocation";
            this.CP_TextBoxTargetExecutableLocation.Size = new System.Drawing.Size(426, 22);
            this.CP_TextBoxTargetExecutableLocation.TabIndex = 0;
            this.CP_TextBoxTargetExecutableLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CP_TextBoxTargetExecutableLocation_KeyDown);
            // 
            // CP_ButtonFileDialogTargetExecutable
            // 
            this.CP_ButtonFileDialogTargetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonFileDialogTargetExecutable.Location = new System.Drawing.Point(516, 9);
            this.CP_ButtonFileDialogTargetExecutable.MinimumSize = new System.Drawing.Size(39, 22);
            this.CP_ButtonFileDialogTargetExecutable.Name = "CP_ButtonFileDialogTargetExecutable";
            this.CP_ButtonFileDialogTargetExecutable.Size = new System.Drawing.Size(44, 24);
            this.CP_ButtonFileDialogTargetExecutable.TabIndex = 3;
            this.CP_ButtonFileDialogTargetExecutable.Text = "F";
            this.CP_ButtonFileDialogTargetExecutable.UseVisualStyleBackColor = true;
            this.CP_ButtonFileDialogTargetExecutable.Click += new System.EventHandler(this.CP_ButtonFileDialogTargetExecutable_Click);
            // 
            // CP_ButtonRefreshTargetExecutable
            // 
            this.CP_ButtonRefreshTargetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonRefreshTargetExecutable.Location = new System.Drawing.Point(468, 9);
            this.CP_ButtonRefreshTargetExecutable.Margin = new System.Windows.Forms.Padding(1);
            this.CP_ButtonRefreshTargetExecutable.MinimumSize = new System.Drawing.Size(39, 22);
            this.CP_ButtonRefreshTargetExecutable.Name = "CP_ButtonRefreshTargetExecutable";
            this.CP_ButtonRefreshTargetExecutable.Size = new System.Drawing.Size(44, 24);
            this.CP_ButtonRefreshTargetExecutable.TabIndex = 2;
            this.CP_ButtonRefreshTargetExecutable.Text = "R";
            this.CP_ButtonRefreshTargetExecutable.UseVisualStyleBackColor = true;
            this.CP_ButtonRefreshTargetExecutable.Click += new System.EventHandler(this.CP_ButtonRefreshTargetExecutable_Click);
            // 
            // ConfigurationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CP_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ConfigurationPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ConfigurationPanel";
            this.Load += new System.EventHandler(this.ConfigurationPanel_Load);
            this.CP_MainPanel.ResumeLayout(false);
            this.CP_ModFolderTable.ResumeLayout(false);
            this.CP_FolderListPanel.ResumeLayout(false);
            this.CP_SettingsView.ResumeLayout(false);
            this.CP_TableSettings.ResumeLayout(false);
            this.CP_NiceGroupModFolderSettings.ResumeLayout(false);
            this.CP_TableModFolderSettings.ResumeLayout(false);
            this.CP_TableModFolderSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_PictureBoxModFolderValidation)).EndInit();
            this.CP_TableTopBar.ResumeLayout(false);
            this.CP_TableTopBarTools.ResumeLayout(false);
            this.CP_NiceGroupTargetExecutable.ResumeLayout(false);
            this.CP_TableTargetExecutable.ResumeLayout(false);
            this.CP_TableTargetExecutable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_PictureBoxTargetExecutableValidation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel CP_ModFolderTable;
        private System.Windows.Forms.Panel CP_FolderListPanel;
        private System.Windows.Forms.TreeView CP_ModFolderTreeView;
        private System.Windows.Forms.Panel CP_SettingsView;
        private System.Windows.Forms.TableLayoutPanel CP_TableSettings;
        private NiceGroupBox CP_NiceGroupLauncherSettings;
        private NiceGroupBox CP_NiceGroupModFolderSettings;
        private NiceGroupBox CP_NiceGroupGameParameters;
        private NiceGroupBox CP_NiceGroupServerSettings;
        private System.Windows.Forms.TableLayoutPanel CP_TableModFolderSettings;
        private System.Windows.Forms.TextBox CP_TextBoxModFolderLocation;
        private System.Windows.Forms.Button CP_ButtonRefreshModFolderLocation;
        private System.Windows.Forms.Button CP_ButtonModFolderFileDialog;
        private System.Windows.Forms.TextBox CP_TextBoxTargetExecutableLocation;
        private System.Windows.Forms.TableLayoutPanel CP_TableTopBar;
        private NiceGroupBox CP_NiceGroupTargetExecutable;
        private System.Windows.Forms.TableLayoutPanel CP_TableTargetExecutable;
        private System.Windows.Forms.Button CP_ButtonFileDialogTargetExecutable;
        private System.Windows.Forms.Button CP_ButtonRefreshTargetExecutable;
        private System.Windows.Forms.TableLayoutPanel CP_TableTopBarTools;
        private System.Windows.Forms.Button CP_ButtonSaveConfiguration;
        private System.Windows.Forms.Button CP_ButtonExportConfigFileDialog;
        private System.Windows.Forms.Button CP_ButtonReturnStarterPage;
        private System.Windows.Forms.PictureBox CP_PictureBoxModFolderValidation;
        private System.Windows.Forms.PictureBox CP_PictureBoxTargetExecutableValidation;
    }
}