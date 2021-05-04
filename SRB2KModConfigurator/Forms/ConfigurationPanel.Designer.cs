
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
            this.CP_TableMainSettingsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CP_OverrideSettingsView = new System.Windows.Forms.Panel();
            this.CP_TableSettings = new System.Windows.Forms.TableLayoutPanel();
            this.CP_NiceGroupServerParameters = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_PanelServerSettings = new System.Windows.Forms.Panel();
            this.CP_NiceGroupAudioParameters = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_PanelAudioSettings = new System.Windows.Forms.Panel();
            this.CP_NiceGroupVideoSettings = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_PanelVideoSettings = new System.Windows.Forms.Panel();
            this.CP_NiceGroupGeneralSettings = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_PanelGeneralSettings = new System.Windows.Forms.Panel();
            this.CP_TableConfigurationSettingsView = new System.Windows.Forms.TableLayoutPanel();
            this.CP_NiceGroupConfigurationSettings = new SRB2KModConfigurator.NiceGroupBox();
            this.CP_TableConfigurationSettings = new System.Windows.Forms.TableLayoutPanel();
            this.CP_CheckboxEnableOverrideSettings = new System.Windows.Forms.CheckBox();
            this.CP_LabelEnableOverrideSettings = new System.Windows.Forms.Label();
            this.CP_LabelConfigurationName = new System.Windows.Forms.Label();
            this.CP_TextboxConfigurationName = new System.Windows.Forms.TextBox();
            this.CP_MainPanel.SuspendLayout();
            this.CP_ModFolderTable.SuspendLayout();
            this.CP_FolderListPanel.SuspendLayout();
            this.CP_NiceGroupModFolderSettings.SuspendLayout();
            this.CP_TableModFolderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_PictureBoxModFolderValidation)).BeginInit();
            this.CP_TableTopBar.SuspendLayout();
            this.CP_TableTopBarTools.SuspendLayout();
            this.CP_NiceGroupTargetExecutable.SuspendLayout();
            this.CP_TableTargetExecutable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CP_PictureBoxTargetExecutableValidation)).BeginInit();
            this.CP_TableMainSettingsContainer.SuspendLayout();
            this.CP_OverrideSettingsView.SuspendLayout();
            this.CP_TableSettings.SuspendLayout();
            this.CP_NiceGroupServerParameters.SuspendLayout();
            this.CP_NiceGroupAudioParameters.SuspendLayout();
            this.CP_NiceGroupVideoSettings.SuspendLayout();
            this.CP_NiceGroupGeneralSettings.SuspendLayout();
            this.CP_TableConfigurationSettingsView.SuspendLayout();
            this.CP_NiceGroupConfigurationSettings.SuspendLayout();
            this.CP_TableConfigurationSettings.SuspendLayout();
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
            this.CP_ModFolderTable.Controls.Add(this.CP_NiceGroupModFolderSettings, 0, 0);
            this.CP_ModFolderTable.Controls.Add(this.CP_TableTopBar, 1, 0);
            this.CP_ModFolderTable.Controls.Add(this.CP_TableMainSettingsContainer, 1, 1);
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
            this.CP_ButtonModFolderFileDialog.BackColor = System.Drawing.Color.White;
            this.CP_ButtonModFolderFileDialog.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_folder;
            this.CP_ButtonModFolderFileDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CP_ButtonModFolderFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonModFolderFileDialog.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonModFolderFileDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonModFolderFileDialog.Location = new System.Drawing.Point(407, 9);
            this.CP_ButtonModFolderFileDialog.Name = "CP_ButtonModFolderFileDialog";
            this.CP_ButtonModFolderFileDialog.Size = new System.Drawing.Size(41, 24);
            this.CP_ButtonModFolderFileDialog.TabIndex = 2;
            this.CP_ButtonModFolderFileDialog.UseVisualStyleBackColor = false;
            this.CP_ButtonModFolderFileDialog.Click += new System.EventHandler(this.CP_ButtonModFolderFileDialog_Click);
            // 
            // CP_ButtonRefreshModFolderLocation
            // 
            this.CP_ButtonRefreshModFolderLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonRefreshModFolderLocation.BackColor = System.Drawing.Color.White;
            this.CP_ButtonRefreshModFolderLocation.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_refresh;
            this.CP_ButtonRefreshModFolderLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CP_ButtonRefreshModFolderLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonRefreshModFolderLocation.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonRefreshModFolderLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonRefreshModFolderLocation.Location = new System.Drawing.Point(360, 9);
            this.CP_ButtonRefreshModFolderLocation.Name = "CP_ButtonRefreshModFolderLocation";
            this.CP_ButtonRefreshModFolderLocation.Size = new System.Drawing.Size(41, 24);
            this.CP_ButtonRefreshModFolderLocation.TabIndex = 1;
            this.CP_ButtonRefreshModFolderLocation.UseVisualStyleBackColor = false;
            this.CP_ButtonRefreshModFolderLocation.Click += new System.EventHandler(this.CP_ButtonRefreshFolderLocation_Click);
            // 
            // CP_TableTopBar
            // 
            this.CP_TableTopBar.ColumnCount = 3;
            this.CP_TableTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.059603F));
            this.CP_TableTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.9404F));
            this.CP_TableTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.CP_TableTopBar.Controls.Add(this.CP_TableTopBarTools, 2, 0);
            this.CP_TableTopBar.Controls.Add(this.CP_NiceGroupTargetExecutable, 1, 0);
            this.CP_TableTopBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_TableTopBar.Location = new System.Drawing.Point(480, 8);
            this.CP_TableTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.CP_TableTopBar.Name = "CP_TableTopBar";
            this.CP_TableTopBar.RowCount = 1;
            this.CP_TableTopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CP_TableTopBar.Size = new System.Drawing.Size(776, 57);
            this.CP_TableTopBar.TabIndex = 5;
            // 
            // CP_TableTopBarTools
            // 
            this.CP_TableTopBarTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_TableTopBarTools.ColumnCount = 3;
            this.CP_TableTopBarTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90944F));
            this.CP_TableTopBarTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.90943F));
            this.CP_TableTopBarTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.18113F));
            this.CP_TableTopBarTools.Controls.Add(this.CP_ButtonSaveConfiguration, 0, 0);
            this.CP_TableTopBarTools.Controls.Add(this.CP_ButtonExportConfigFileDialog, 1, 0);
            this.CP_TableTopBarTools.Controls.Add(this.CP_ButtonReturnStarterPage, 2, 0);
            this.CP_TableTopBarTools.Location = new System.Drawing.Point(558, 6);
            this.CP_TableTopBarTools.Name = "CP_TableTopBarTools";
            this.CP_TableTopBarTools.RowCount = 1;
            this.CP_TableTopBarTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CP_TableTopBarTools.Size = new System.Drawing.Size(215, 44);
            this.CP_TableTopBarTools.TabIndex = 1;
            // 
            // CP_ButtonSaveConfiguration
            // 
            this.CP_ButtonSaveConfiguration.BackColor = System.Drawing.Color.White;
            this.CP_ButtonSaveConfiguration.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_crosss;
            this.CP_ButtonSaveConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CP_ButtonSaveConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ButtonSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonSaveConfiguration.Font = new System.Drawing.Font("envypn7x15", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonSaveConfiguration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonSaveConfiguration.Location = new System.Drawing.Point(1, 1);
            this.CP_ButtonSaveConfiguration.Margin = new System.Windows.Forms.Padding(1);
            this.CP_ButtonSaveConfiguration.Name = "CP_ButtonSaveConfiguration";
            this.CP_ButtonSaveConfiguration.Size = new System.Drawing.Size(64, 42);
            this.CP_ButtonSaveConfiguration.TabIndex = 0;
            this.CP_ButtonSaveConfiguration.Text = "Save";
            this.CP_ButtonSaveConfiguration.UseVisualStyleBackColor = false;
            this.CP_ButtonSaveConfiguration.Click += new System.EventHandler(this.CP_ButtonSaveConfiguration_Click);
            // 
            // CP_ButtonExportConfigFileDialog
            // 
            this.CP_ButtonExportConfigFileDialog.BackColor = System.Drawing.Color.White;
            this.CP_ButtonExportConfigFileDialog.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_crosss;
            this.CP_ButtonExportConfigFileDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CP_ButtonExportConfigFileDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ButtonExportConfigFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonExportConfigFileDialog.Font = new System.Drawing.Font("envypn7x15", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonExportConfigFileDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonExportConfigFileDialog.Location = new System.Drawing.Point(67, 1);
            this.CP_ButtonExportConfigFileDialog.Margin = new System.Windows.Forms.Padding(1);
            this.CP_ButtonExportConfigFileDialog.Name = "CP_ButtonExportConfigFileDialog";
            this.CP_ButtonExportConfigFileDialog.Size = new System.Drawing.Size(64, 42);
            this.CP_ButtonExportConfigFileDialog.TabIndex = 1;
            this.CP_ButtonExportConfigFileDialog.Text = "Export";
            this.CP_ButtonExportConfigFileDialog.UseVisualStyleBackColor = false;
            this.CP_ButtonExportConfigFileDialog.Click += new System.EventHandler(this.CP_ButtonExportConfigFileDialog_Click);
            // 
            // CP_ButtonReturnStarterPage
            // 
            this.CP_ButtonReturnStarterPage.BackColor = System.Drawing.Color.White;
            this.CP_ButtonReturnStarterPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_ButtonReturnStarterPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonReturnStarterPage.Font = new System.Drawing.Font("envypn7x15", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonReturnStarterPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonReturnStarterPage.Location = new System.Drawing.Point(133, 1);
            this.CP_ButtonReturnStarterPage.Margin = new System.Windows.Forms.Padding(1);
            this.CP_ButtonReturnStarterPage.Name = "CP_ButtonReturnStarterPage";
            this.CP_ButtonReturnStarterPage.Size = new System.Drawing.Size(81, 42);
            this.CP_ButtonReturnStarterPage.TabIndex = 2;
            this.CP_ButtonReturnStarterPage.Text = "Return";
            this.CP_ButtonReturnStarterPage.UseVisualStyleBackColor = false;
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
            this.CP_NiceGroupTargetExecutable.Location = new System.Drawing.Point(8, 3);
            this.CP_NiceGroupTargetExecutable.Name = "CP_NiceGroupTargetExecutable";
            this.CP_NiceGroupTargetExecutable.Padding = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.CP_NiceGroupTargetExecutable.Size = new System.Drawing.Size(544, 51);
            this.CP_NiceGroupTargetExecutable.TabIndex = 0;
            this.CP_NiceGroupTargetExecutable.TabStop = false;
            this.CP_NiceGroupTargetExecutable.Text = "Target Executable";
            // 
            // CP_TableTargetExecutable
            // 
            this.CP_TableTargetExecutable.BackColor = System.Drawing.Color.Transparent;
            this.CP_TableTargetExecutable.ColumnCount = 4;
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.CP_TableTargetExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.CP_TableTargetExecutable.Controls.Add(this.CP_PictureBoxTargetExecutableValidation, 0, 0);
            this.CP_TableTargetExecutable.Controls.Add(this.CP_TextBoxTargetExecutableLocation, 0, 0);
            this.CP_TableTargetExecutable.Controls.Add(this.CP_ButtonFileDialogTargetExecutable, 3, 0);
            this.CP_TableTargetExecutable.Controls.Add(this.CP_ButtonRefreshTargetExecutable, 2, 0);
            this.CP_TableTargetExecutable.Location = new System.Drawing.Point(3, 7);
            this.CP_TableTargetExecutable.Name = "CP_TableTargetExecutable";
            this.CP_TableTargetExecutable.Padding = new System.Windows.Forms.Padding(2, 0, 2, 1);
            this.CP_TableTargetExecutable.RowCount = 1;
            this.CP_TableTargetExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableTargetExecutable.Size = new System.Drawing.Size(548, 44);
            this.CP_TableTargetExecutable.TabIndex = 0;
            // 
            // CP_PictureBoxTargetExecutableValidation
            // 
            this.CP_PictureBoxTargetExecutableValidation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CP_PictureBoxTargetExecutableValidation.BackColor = System.Drawing.Color.Transparent;
            this.CP_PictureBoxTargetExecutableValidation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CP_PictureBoxTargetExecutableValidation.Image = global::SRB2KModConfigurator.Properties.Resources.spr_checkmark;
            this.CP_PictureBoxTargetExecutableValidation.Location = new System.Drawing.Point(429, 9);
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
            this.CP_TextBoxTargetExecutableLocation.Size = new System.Drawing.Size(416, 22);
            this.CP_TextBoxTargetExecutableLocation.TabIndex = 0;
            this.CP_TextBoxTargetExecutableLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CP_TextBoxTargetExecutableLocation_KeyDown);
            // 
            // CP_ButtonFileDialogTargetExecutable
            // 
            this.CP_ButtonFileDialogTargetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonFileDialogTargetExecutable.BackColor = System.Drawing.Color.White;
            this.CP_ButtonFileDialogTargetExecutable.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_folder;
            this.CP_ButtonFileDialogTargetExecutable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CP_ButtonFileDialogTargetExecutable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonFileDialogTargetExecutable.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonFileDialogTargetExecutable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonFileDialogTargetExecutable.Location = new System.Drawing.Point(502, 10);
            this.CP_ButtonFileDialogTargetExecutable.MaximumSize = new System.Drawing.Size(40, 23);
            this.CP_ButtonFileDialogTargetExecutable.MinimumSize = new System.Drawing.Size(39, 22);
            this.CP_ButtonFileDialogTargetExecutable.Name = "CP_ButtonFileDialogTargetExecutable";
            this.CP_ButtonFileDialogTargetExecutable.Size = new System.Drawing.Size(40, 23);
            this.CP_ButtonFileDialogTargetExecutable.TabIndex = 3;
            this.CP_ButtonFileDialogTargetExecutable.UseVisualStyleBackColor = false;
            this.CP_ButtonFileDialogTargetExecutable.Click += new System.EventHandler(this.CP_ButtonFileDialogTargetExecutable_Click);
            // 
            // CP_ButtonRefreshTargetExecutable
            // 
            this.CP_ButtonRefreshTargetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_ButtonRefreshTargetExecutable.BackColor = System.Drawing.Color.White;
            this.CP_ButtonRefreshTargetExecutable.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_refresh;
            this.CP_ButtonRefreshTargetExecutable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CP_ButtonRefreshTargetExecutable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CP_ButtonRefreshTargetExecutable.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_ButtonRefreshTargetExecutable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CP_ButtonRefreshTargetExecutable.Location = new System.Drawing.Point(457, 10);
            this.CP_ButtonRefreshTargetExecutable.Margin = new System.Windows.Forms.Padding(1);
            this.CP_ButtonRefreshTargetExecutable.MaximumSize = new System.Drawing.Size(40, 23);
            this.CP_ButtonRefreshTargetExecutable.MinimumSize = new System.Drawing.Size(39, 22);
            this.CP_ButtonRefreshTargetExecutable.Name = "CP_ButtonRefreshTargetExecutable";
            this.CP_ButtonRefreshTargetExecutable.Size = new System.Drawing.Size(40, 23);
            this.CP_ButtonRefreshTargetExecutable.TabIndex = 2;
            this.CP_ButtonRefreshTargetExecutable.UseVisualStyleBackColor = false;
            this.CP_ButtonRefreshTargetExecutable.Click += new System.EventHandler(this.CP_ButtonRefreshTargetExecutable_Click);
            // 
            // CP_TableMainSettingsContainer
            // 
            this.CP_TableMainSettingsContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CP_TableMainSettingsContainer.ColumnCount = 1;
            this.CP_TableMainSettingsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableMainSettingsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableMainSettingsContainer.Controls.Add(this.CP_OverrideSettingsView, 0, 1);
            this.CP_TableMainSettingsContainer.Controls.Add(this.CP_TableConfigurationSettingsView, 0, 0);
            this.CP_TableMainSettingsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_TableMainSettingsContainer.Location = new System.Drawing.Point(480, 68);
            this.CP_TableMainSettingsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CP_TableMainSettingsContainer.Name = "CP_TableMainSettingsContainer";
            this.CP_TableMainSettingsContainer.RowCount = 2;
            this.CP_TableMainSettingsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.54305F));
            this.CP_TableMainSettingsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.45695F));
            this.CP_TableMainSettingsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CP_TableMainSettingsContainer.Size = new System.Drawing.Size(776, 605);
            this.CP_TableMainSettingsContainer.TabIndex = 1;
            // 
            // CP_OverrideSettingsView
            // 
            this.CP_OverrideSettingsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_OverrideSettingsView.AutoScroll = true;
            this.CP_OverrideSettingsView.Controls.Add(this.CP_TableSettings);
            this.CP_OverrideSettingsView.Location = new System.Drawing.Point(4, 116);
            this.CP_OverrideSettingsView.Name = "CP_OverrideSettingsView";
            this.CP_OverrideSettingsView.Size = new System.Drawing.Size(768, 485);
            this.CP_OverrideSettingsView.TabIndex = 1;
            // 
            // CP_TableSettings
            // 
            this.CP_TableSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CP_TableSettings.ColumnCount = 1;
            this.CP_TableSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupServerParameters, 0, 3);
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupAudioParameters, 0, 2);
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupVideoSettings, 0, 1);
            this.CP_TableSettings.Controls.Add(this.CP_NiceGroupGeneralSettings, 0, 0);
            this.CP_TableSettings.Location = new System.Drawing.Point(0, 0);
            this.CP_TableSettings.Name = "CP_TableSettings";
            this.CP_TableSettings.Padding = new System.Windows.Forms.Padding(4);
            this.CP_TableSettings.RowCount = 4;
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.CP_TableSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.CP_TableSettings.Size = new System.Drawing.Size(750, 843);
            this.CP_TableSettings.TabIndex = 0;
            // 
            // CP_NiceGroupServerParameters
            // 
            this.CP_NiceGroupServerParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupServerParameters.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupServerParameters.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupServerParameters.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupServerParameters.Controls.Add(this.CP_PanelServerSettings);
            this.CP_NiceGroupServerParameters.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupServerParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupServerParameters.Location = new System.Drawing.Point(7, 472);
            this.CP_NiceGroupServerParameters.MinimumSize = new System.Drawing.Size(100, 50);
            this.CP_NiceGroupServerParameters.Name = "CP_NiceGroupServerParameters";
            this.CP_NiceGroupServerParameters.Size = new System.Drawing.Size(736, 365);
            this.CP_NiceGroupServerParameters.TabIndex = 3;
            this.CP_NiceGroupServerParameters.TabStop = false;
            this.CP_NiceGroupServerParameters.Text = "Server Settings";
            // 
            // CP_PanelServerSettings
            // 
            this.CP_PanelServerSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_PanelServerSettings.Location = new System.Drawing.Point(9, 20);
            this.CP_PanelServerSettings.Margin = new System.Windows.Forms.Padding(0);
            this.CP_PanelServerSettings.Name = "CP_PanelServerSettings";
            this.CP_PanelServerSettings.Size = new System.Drawing.Size(718, 338);
            this.CP_PanelServerSettings.TabIndex = 3;
            // 
            // CP_NiceGroupAudioParameters
            // 
            this.CP_NiceGroupAudioParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupAudioParameters.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupAudioParameters.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupAudioParameters.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupAudioParameters.Controls.Add(this.CP_PanelAudioSettings);
            this.CP_NiceGroupAudioParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupAudioParameters.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupAudioParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupAudioParameters.Location = new System.Drawing.Point(7, 390);
            this.CP_NiceGroupAudioParameters.MinimumSize = new System.Drawing.Size(100, 50);
            this.CP_NiceGroupAudioParameters.Name = "CP_NiceGroupAudioParameters";
            this.CP_NiceGroupAudioParameters.Size = new System.Drawing.Size(736, 76);
            this.CP_NiceGroupAudioParameters.TabIndex = 2;
            this.CP_NiceGroupAudioParameters.TabStop = false;
            this.CP_NiceGroupAudioParameters.Text = "Audio Settings";
            // 
            // CP_PanelAudioSettings
            // 
            this.CP_PanelAudioSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_PanelAudioSettings.Location = new System.Drawing.Point(9, 18);
            this.CP_PanelAudioSettings.Margin = new System.Windows.Forms.Padding(0);
            this.CP_PanelAudioSettings.Name = "CP_PanelAudioSettings";
            this.CP_PanelAudioSettings.Size = new System.Drawing.Size(718, 50);
            this.CP_PanelAudioSettings.TabIndex = 2;
            // 
            // CP_NiceGroupVideoSettings
            // 
            this.CP_NiceGroupVideoSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupVideoSettings.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupVideoSettings.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupVideoSettings.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupVideoSettings.Controls.Add(this.CP_PanelVideoSettings);
            this.CP_NiceGroupVideoSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupVideoSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupVideoSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupVideoSettings.Location = new System.Drawing.Point(7, 235);
            this.CP_NiceGroupVideoSettings.MinimumSize = new System.Drawing.Size(100, 50);
            this.CP_NiceGroupVideoSettings.Name = "CP_NiceGroupVideoSettings";
            this.CP_NiceGroupVideoSettings.Size = new System.Drawing.Size(736, 149);
            this.CP_NiceGroupVideoSettings.TabIndex = 1;
            this.CP_NiceGroupVideoSettings.TabStop = false;
            this.CP_NiceGroupVideoSettings.Text = "Video Settings";
            // 
            // CP_PanelVideoSettings
            // 
            this.CP_PanelVideoSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_PanelVideoSettings.Location = new System.Drawing.Point(8, 18);
            this.CP_PanelVideoSettings.Margin = new System.Windows.Forms.Padding(0);
            this.CP_PanelVideoSettings.Name = "CP_PanelVideoSettings";
            this.CP_PanelVideoSettings.Size = new System.Drawing.Size(718, 122);
            this.CP_PanelVideoSettings.TabIndex = 1;
            // 
            // CP_NiceGroupGeneralSettings
            // 
            this.CP_NiceGroupGeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupGeneralSettings.BorderColor = System.Drawing.Color.White;
            this.CP_NiceGroupGeneralSettings.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupGeneralSettings.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupGeneralSettings.Controls.Add(this.CP_PanelGeneralSettings);
            this.CP_NiceGroupGeneralSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupGeneralSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupGeneralSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupGeneralSettings.Location = new System.Drawing.Point(7, 7);
            this.CP_NiceGroupGeneralSettings.MinimumSize = new System.Drawing.Size(100, 100);
            this.CP_NiceGroupGeneralSettings.Name = "CP_NiceGroupGeneralSettings";
            this.CP_NiceGroupGeneralSettings.Size = new System.Drawing.Size(736, 222);
            this.CP_NiceGroupGeneralSettings.TabIndex = 0;
            this.CP_NiceGroupGeneralSettings.TabStop = false;
            this.CP_NiceGroupGeneralSettings.Text = "General Settings";
            // 
            // CP_PanelGeneralSettings
            // 
            this.CP_PanelGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_PanelGeneralSettings.Location = new System.Drawing.Point(8, 18);
            this.CP_PanelGeneralSettings.Margin = new System.Windows.Forms.Padding(0);
            this.CP_PanelGeneralSettings.Name = "CP_PanelGeneralSettings";
            this.CP_PanelGeneralSettings.Size = new System.Drawing.Size(718, 195);
            this.CP_PanelGeneralSettings.TabIndex = 0;
            // 
            // CP_TableConfigurationSettingsView
            // 
            this.CP_TableConfigurationSettingsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CP_TableConfigurationSettingsView.ColumnCount = 1;
            this.CP_TableConfigurationSettingsView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableConfigurationSettingsView.Controls.Add(this.CP_NiceGroupConfigurationSettings, 0, 0);
            this.CP_TableConfigurationSettingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_TableConfigurationSettingsView.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CP_TableConfigurationSettingsView.Location = new System.Drawing.Point(4, 4);
            this.CP_TableConfigurationSettingsView.Name = "CP_TableConfigurationSettingsView";
            this.CP_TableConfigurationSettingsView.Padding = new System.Windows.Forms.Padding(4, 4, 22, 4);
            this.CP_TableConfigurationSettingsView.RowCount = 1;
            this.CP_TableConfigurationSettingsView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableConfigurationSettingsView.Size = new System.Drawing.Size(768, 105);
            this.CP_TableConfigurationSettingsView.TabIndex = 2;
            // 
            // CP_NiceGroupConfigurationSettings
            // 
            this.CP_NiceGroupConfigurationSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CP_NiceGroupConfigurationSettings.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.CP_NiceGroupConfigurationSettings.BorderRectangleHeightOffset = 0;
            this.CP_NiceGroupConfigurationSettings.BorderRectangleWidthOffset = 4;
            this.CP_NiceGroupConfigurationSettings.Controls.Add(this.CP_TableConfigurationSettings);
            this.CP_NiceGroupConfigurationSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_NiceGroupConfigurationSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_NiceGroupConfigurationSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_NiceGroupConfigurationSettings.Location = new System.Drawing.Point(7, 7);
            this.CP_NiceGroupConfigurationSettings.MinimumSize = new System.Drawing.Size(100, 0);
            this.CP_NiceGroupConfigurationSettings.Name = "CP_NiceGroupConfigurationSettings";
            this.CP_NiceGroupConfigurationSettings.Size = new System.Drawing.Size(736, 91);
            this.CP_NiceGroupConfigurationSettings.TabIndex = 2;
            this.CP_NiceGroupConfigurationSettings.TabStop = false;
            this.CP_NiceGroupConfigurationSettings.Text = "Configuration Settings";
            // 
            // CP_TableConfigurationSettings
            // 
            this.CP_TableConfigurationSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CP_TableConfigurationSettings.ColumnCount = 2;
            this.CP_TableConfigurationSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.43F));
            this.CP_TableConfigurationSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57F));
            this.CP_TableConfigurationSettings.Controls.Add(this.CP_CheckboxEnableOverrideSettings, 1, 1);
            this.CP_TableConfigurationSettings.Controls.Add(this.CP_LabelEnableOverrideSettings, 0, 1);
            this.CP_TableConfigurationSettings.Controls.Add(this.CP_LabelConfigurationName, 0, 0);
            this.CP_TableConfigurationSettings.Controls.Add(this.CP_TextboxConfigurationName, 1, 0);
            this.CP_TableConfigurationSettings.Location = new System.Drawing.Point(8, 16);
            this.CP_TableConfigurationSettings.Name = "CP_TableConfigurationSettings";
            this.CP_TableConfigurationSettings.RowCount = 2;
            this.CP_TableConfigurationSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableConfigurationSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CP_TableConfigurationSettings.Size = new System.Drawing.Size(718, 68);
            this.CP_TableConfigurationSettings.TabIndex = 0;
            // 
            // CP_CheckboxEnableOverrideSettings
            // 
            this.CP_CheckboxEnableOverrideSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_CheckboxEnableOverrideSettings.AutoSize = true;
            this.CP_CheckboxEnableOverrideSettings.Location = new System.Drawing.Point(186, 43);
            this.CP_CheckboxEnableOverrideSettings.Name = "CP_CheckboxEnableOverrideSettings";
            this.CP_CheckboxEnableOverrideSettings.Size = new System.Drawing.Size(528, 14);
            this.CP_CheckboxEnableOverrideSettings.TabIndex = 28;
            this.CP_CheckboxEnableOverrideSettings.UseVisualStyleBackColor = true;
            this.CP_CheckboxEnableOverrideSettings.CheckedChanged += new System.EventHandler(this.CP_CheckboxEnableOverrideSettings_CheckedChanged);
            // 
            // CP_LabelEnableOverrideSettings
            // 
            this.CP_LabelEnableOverrideSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_LabelEnableOverrideSettings.AutoSize = true;
            this.CP_LabelEnableOverrideSettings.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_LabelEnableOverrideSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_LabelEnableOverrideSettings.Location = new System.Drawing.Point(4, 36);
            this.CP_LabelEnableOverrideSettings.Name = "CP_LabelEnableOverrideSettings";
            this.CP_LabelEnableOverrideSettings.Size = new System.Drawing.Size(175, 28);
            this.CP_LabelEnableOverrideSettings.TabIndex = 4;
            this.CP_LabelEnableOverrideSettings.Text = "Enable Override Settings";
            // 
            // CP_LabelConfigurationName
            // 
            this.CP_LabelConfigurationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_LabelConfigurationName.AutoSize = true;
            this.CP_LabelConfigurationName.Font = new System.Drawing.Font("envypn7x15", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CP_LabelConfigurationName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CP_LabelConfigurationName.Location = new System.Drawing.Point(4, 9);
            this.CP_LabelConfigurationName.Name = "CP_LabelConfigurationName";
            this.CP_LabelConfigurationName.Size = new System.Drawing.Size(175, 16);
            this.CP_LabelConfigurationName.TabIndex = 2;
            this.CP_LabelConfigurationName.Text = "Config Name";
            // 
            // CP_TextboxConfigurationName
            // 
            this.CP_TextboxConfigurationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CP_TextboxConfigurationName.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CP_TextboxConfigurationName.Location = new System.Drawing.Point(186, 6);
            this.CP_TextboxConfigurationName.Name = "CP_TextboxConfigurationName";
            this.CP_TextboxConfigurationName.ReadOnly = true;
            this.CP_TextboxConfigurationName.Size = new System.Drawing.Size(528, 22);
            this.CP_TextboxConfigurationName.TabIndex = 3;
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
            this.CP_TableMainSettingsContainer.ResumeLayout(false);
            this.CP_OverrideSettingsView.ResumeLayout(false);
            this.CP_TableSettings.ResumeLayout(false);
            this.CP_NiceGroupServerParameters.ResumeLayout(false);
            this.CP_NiceGroupAudioParameters.ResumeLayout(false);
            this.CP_NiceGroupVideoSettings.ResumeLayout(false);
            this.CP_NiceGroupGeneralSettings.ResumeLayout(false);
            this.CP_TableConfigurationSettingsView.ResumeLayout(false);
            this.CP_NiceGroupConfigurationSettings.ResumeLayout(false);
            this.CP_TableConfigurationSettings.ResumeLayout(false);
            this.CP_TableConfigurationSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel CP_ModFolderTable;
        private System.Windows.Forms.Panel CP_FolderListPanel;
        private System.Windows.Forms.TreeView CP_ModFolderTreeView;
        private System.Windows.Forms.Panel CP_OverrideSettingsView;
        private System.Windows.Forms.TableLayoutPanel CP_TableSettings;
        private NiceGroupBox CP_NiceGroupGeneralSettings;
        private NiceGroupBox CP_NiceGroupModFolderSettings;
        private NiceGroupBox CP_NiceGroupAudioParameters;
        private NiceGroupBox CP_NiceGroupVideoSettings;
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
        private NiceGroupBox CP_NiceGroupServerParameters;
        private System.Windows.Forms.Panel CP_PanelGeneralSettings;
        private System.Windows.Forms.Panel CP_PanelVideoSettings;
        private System.Windows.Forms.Panel CP_PanelAudioSettings;
        private System.Windows.Forms.Panel CP_PanelServerSettings;
        private System.Windows.Forms.TableLayoutPanel CP_TableMainSettingsContainer;
        private NiceGroupBox CP_NiceGroupConfigurationSettings;
        private System.Windows.Forms.TableLayoutPanel CP_TableConfigurationSettingsView;
        private System.Windows.Forms.TableLayoutPanel CP_TableConfigurationSettings;
        private System.Windows.Forms.Label CP_LabelConfigurationName;
        public System.Windows.Forms.TextBox CP_TextboxConfigurationName;
        private System.Windows.Forms.Label CP_LabelEnableOverrideSettings;
        private System.Windows.Forms.CheckBox CP_CheckboxEnableOverrideSettings;
    }
}