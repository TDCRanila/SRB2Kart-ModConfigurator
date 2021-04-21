
namespace SRB2KModConfigurator.Forms
{
    partial class ServerSettingsPanel
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
            this.components = new System.ComponentModel.Container();
            this.SSP_MainPanel = new System.Windows.Forms.Panel();
            this.SSP_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SSP_LabelEnableServer = new System.Windows.Forms.Label();
            this.SSP_LabelServerType = new System.Windows.Forms.Label();
            this.SSP_LabelGameType = new System.Windows.Forms.Label();
            this.SSP_TextBoxGameType = new System.Windows.Forms.TextBox();
            this.SSP_LabelMasterServer = new System.Windows.Forms.Label();
            this.SSP_LabelServerPassword = new System.Windows.Forms.Label();
            this.SSP_TablePasswordSettings = new System.Windows.Forms.TableLayoutPanel();
            this.SSP_CheckboxEnablePassword = new System.Windows.Forms.CheckBox();
            this.SSP_TextboxPassword = new System.Windows.Forms.TextBox();
            this.SSP_TableMasterServer = new System.Windows.Forms.TableLayoutPanel();
            this.SSP_CheckBoxPublicBroadCast = new System.Windows.Forms.CheckBox();
            this.SSP_ComboPublicRoomType = new System.Windows.Forms.ComboBox();
            this.SSP_LabelPreventAddonUpload = new System.Windows.Forms.Label();
            this.SSP_CheckboxPreventAddonUpload = new System.Windows.Forms.CheckBox();
            this.SSP_CheckboxEnableServer = new System.Windows.Forms.CheckBox();
            this.SSP_ComboBoxServerType = new System.Windows.Forms.ComboBox();
            this.GSP_MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SSP_MainPanel.SuspendLayout();
            this.SSP_TableLayout.SuspendLayout();
            this.SSP_TablePasswordSettings.SuspendLayout();
            this.SSP_TableMasterServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSP_MainPanel
            // 
            this.SSP_MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SSP_MainPanel.Controls.Add(this.SSP_TableLayout);
            this.SSP_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSP_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.SSP_MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SSP_MainPanel.Name = "SSP_MainPanel";
            this.SSP_MainPanel.Size = new System.Drawing.Size(720, 250);
            this.SSP_MainPanel.TabIndex = 0;
            // 
            // SSP_TableLayout
            // 
            this.SSP_TableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SSP_TableLayout.ColumnCount = 2;
            this.SSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42857F));
            this.SSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelEnableServer, 0, 0);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelServerType, 0, 1);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelGameType, 0, 4);
            this.SSP_TableLayout.Controls.Add(this.SSP_TextBoxGameType, 1, 4);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelMasterServer, 0, 3);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelServerPassword, 0, 2);
            this.SSP_TableLayout.Controls.Add(this.SSP_TablePasswordSettings, 1, 2);
            this.SSP_TableLayout.Controls.Add(this.SSP_TableMasterServer, 1, 3);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelPreventAddonUpload, 0, 5);
            this.SSP_TableLayout.Controls.Add(this.SSP_CheckboxPreventAddonUpload, 1, 5);
            this.SSP_TableLayout.Controls.Add(this.SSP_CheckboxEnableServer, 1, 0);
            this.SSP_TableLayout.Controls.Add(this.SSP_ComboBoxServerType, 1, 1);
            this.SSP_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSP_TableLayout.Location = new System.Drawing.Point(0, 0);
            this.SSP_TableLayout.Name = "SSP_TableLayout";
            this.SSP_TableLayout.RowCount = 7;
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.60656F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.SSP_TableLayout.Size = new System.Drawing.Size(720, 250);
            this.SSP_TableLayout.TabIndex = 0;
            // 
            // SSP_LabelEnableServer
            // 
            this.SSP_LabelEnableServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelEnableServer.AutoSize = true;
            this.SSP_LabelEnableServer.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelEnableServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelEnableServer.Location = new System.Drawing.Point(4, 7);
            this.SSP_LabelEnableServer.Name = "SSP_LabelEnableServer";
            this.SSP_LabelEnableServer.Size = new System.Drawing.Size(173, 14);
            this.SSP_LabelEnableServer.TabIndex = 0;
            this.SSP_LabelEnableServer.Text = "Enable Server";
            // 
            // SSP_LabelServerType
            // 
            this.SSP_LabelServerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelServerType.AutoSize = true;
            this.SSP_LabelServerType.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelServerType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelServerType.Location = new System.Drawing.Point(4, 43);
            this.SSP_LabelServerType.Name = "SSP_LabelServerType";
            this.SSP_LabelServerType.Size = new System.Drawing.Size(173, 14);
            this.SSP_LabelServerType.TabIndex = 2;
            this.SSP_LabelServerType.Text = "Server Type";
            this.GSP_MasterToolTip.SetToolTip(this.SSP_LabelServerType, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // SSP_LabelGameType
            // 
            this.SSP_LabelGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelGameType.AutoSize = true;
            this.SSP_LabelGameType.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelGameType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelGameType.Location = new System.Drawing.Point(4, 148);
            this.SSP_LabelGameType.Name = "SSP_LabelGameType";
            this.SSP_LabelGameType.Size = new System.Drawing.Size(173, 14);
            this.SSP_LabelGameType.TabIndex = 4;
            this.SSP_LabelGameType.Text = "Game Type";
            // 
            // SSP_TextBoxGameType
            // 
            this.SSP_TextBoxGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextBoxGameType.Location = new System.Drawing.Point(184, 143);
            this.SSP_TextBoxGameType.Name = "SSP_TextBoxGameType";
            this.SSP_TextBoxGameType.Size = new System.Drawing.Size(532, 23);
            this.SSP_TextBoxGameType.TabIndex = 10;
            // 
            // SSP_LabelMasterServer
            // 
            this.SSP_LabelMasterServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelMasterServer.AutoSize = true;
            this.SSP_LabelMasterServer.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelMasterServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelMasterServer.Location = new System.Drawing.Point(4, 106);
            this.SSP_LabelMasterServer.Name = "SSP_LabelMasterServer";
            this.SSP_LabelMasterServer.Size = new System.Drawing.Size(173, 28);
            this.SSP_LabelMasterServer.TabIndex = 6;
            this.SSP_LabelMasterServer.Text = "Public Broadcast (Master ServerList)";
            // 
            // SSP_LabelServerPassword
            // 
            this.SSP_LabelServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelServerPassword.AutoSize = true;
            this.SSP_LabelServerPassword.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelServerPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelServerPassword.Location = new System.Drawing.Point(4, 80);
            this.SSP_LabelServerPassword.Name = "SSP_LabelServerPassword";
            this.SSP_LabelServerPassword.Size = new System.Drawing.Size(173, 14);
            this.SSP_LabelServerPassword.TabIndex = 11;
            this.SSP_LabelServerPassword.Text = "Password";
            this.GSP_MasterToolTip.SetToolTip(this.SSP_LabelServerPassword, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // SSP_TablePasswordSettings
            // 
            this.SSP_TablePasswordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TablePasswordSettings.ColumnCount = 2;
            this.SSP_TablePasswordSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.671078F));
            this.SSP_TablePasswordSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.SSP_TablePasswordSettings.Controls.Add(this.SSP_CheckboxEnablePassword, 0, 0);
            this.SSP_TablePasswordSettings.Controls.Add(this.SSP_TextboxPassword, 1, 0);
            this.SSP_TablePasswordSettings.Location = new System.Drawing.Point(181, 73);
            this.SSP_TablePasswordSettings.Margin = new System.Windows.Forms.Padding(0);
            this.SSP_TablePasswordSettings.Name = "SSP_TablePasswordSettings";
            this.SSP_TablePasswordSettings.RowCount = 1;
            this.SSP_TablePasswordSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SSP_TablePasswordSettings.Size = new System.Drawing.Size(538, 29);
            this.SSP_TablePasswordSettings.TabIndex = 12;
            // 
            // SSP_CheckboxEnablePassword
            // 
            this.SSP_CheckboxEnablePassword.AutoSize = true;
            this.SSP_CheckboxEnablePassword.Location = new System.Drawing.Point(3, 3);
            this.SSP_CheckboxEnablePassword.Name = "SSP_CheckboxEnablePassword";
            this.SSP_CheckboxEnablePassword.Size = new System.Drawing.Size(23, 19);
            this.SSP_CheckboxEnablePassword.TabIndex = 0;
            this.SSP_CheckboxEnablePassword.Text = "checkBox3";
            this.SSP_CheckboxEnablePassword.UseVisualStyleBackColor = true;
            // 
            // SSP_TextboxPassword
            // 
            this.SSP_TextboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextboxPassword.Location = new System.Drawing.Point(32, 3);
            this.SSP_TextboxPassword.Name = "SSP_TextboxPassword";
            this.SSP_TextboxPassword.Size = new System.Drawing.Size(503, 23);
            this.SSP_TextboxPassword.TabIndex = 1;
            // 
            // SSP_TableMasterServer
            // 
            this.SSP_TableMasterServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TableMasterServer.ColumnCount = 2;
            this.SSP_TableMasterServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.477612F));
            this.SSP_TableMasterServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.52238F));
            this.SSP_TableMasterServer.Controls.Add(this.SSP_CheckBoxPublicBroadCast, 0, 0);
            this.SSP_TableMasterServer.Controls.Add(this.SSP_ComboPublicRoomType, 1, 0);
            this.SSP_TableMasterServer.Location = new System.Drawing.Point(181, 103);
            this.SSP_TableMasterServer.Margin = new System.Windows.Forms.Padding(0);
            this.SSP_TableMasterServer.Name = "SSP_TableMasterServer";
            this.SSP_TableMasterServer.RowCount = 1;
            this.SSP_TableMasterServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SSP_TableMasterServer.Size = new System.Drawing.Size(538, 34);
            this.SSP_TableMasterServer.TabIndex = 13;
            // 
            // SSP_CheckBoxPublicBroadCast
            // 
            this.SSP_CheckBoxPublicBroadCast.AutoSize = true;
            this.SSP_CheckBoxPublicBroadCast.Location = new System.Drawing.Point(3, 3);
            this.SSP_CheckBoxPublicBroadCast.Name = "SSP_CheckBoxPublicBroadCast";
            this.SSP_CheckBoxPublicBroadCast.Size = new System.Drawing.Size(15, 14);
            this.SSP_CheckBoxPublicBroadCast.TabIndex = 0;
            this.SSP_CheckBoxPublicBroadCast.UseVisualStyleBackColor = true;
            // 
            // SSP_ComboPublicRoomType
            // 
            this.SSP_ComboPublicRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_ComboPublicRoomType.FormattingEnabled = true;
            this.SSP_ComboPublicRoomType.Location = new System.Drawing.Point(27, 5);
            this.SSP_ComboPublicRoomType.Name = "SSP_ComboPublicRoomType";
            this.SSP_ComboPublicRoomType.Size = new System.Drawing.Size(508, 23);
            this.SSP_ComboPublicRoomType.TabIndex = 1;
            // 
            // SSP_LabelPreventAddonUpload
            // 
            this.SSP_LabelPreventAddonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelPreventAddonUpload.AutoSize = true;
            this.SSP_LabelPreventAddonUpload.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelPreventAddonUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelPreventAddonUpload.Location = new System.Drawing.Point(4, 182);
            this.SSP_LabelPreventAddonUpload.Name = "SSP_LabelPreventAddonUpload";
            this.SSP_LabelPreventAddonUpload.Size = new System.Drawing.Size(173, 14);
            this.SSP_LabelPreventAddonUpload.TabIndex = 14;
            this.SSP_LabelPreventAddonUpload.Text = "Prevent Addon Upload";
            // 
            // SSP_CheckboxPreventAddonUpload
            // 
            this.SSP_CheckboxPreventAddonUpload.AutoSize = true;
            this.SSP_CheckboxPreventAddonUpload.Location = new System.Drawing.Point(184, 176);
            this.SSP_CheckboxPreventAddonUpload.Name = "SSP_CheckboxPreventAddonUpload";
            this.SSP_CheckboxPreventAddonUpload.Size = new System.Drawing.Size(15, 14);
            this.SSP_CheckboxPreventAddonUpload.TabIndex = 15;
            this.SSP_CheckboxPreventAddonUpload.UseVisualStyleBackColor = true;
            // 
            // SSP_CheckboxEnableServer
            // 
            this.SSP_CheckboxEnableServer.AutoSize = true;
            this.SSP_CheckboxEnableServer.Location = new System.Drawing.Point(184, 4);
            this.SSP_CheckboxEnableServer.Name = "SSP_CheckboxEnableServer";
            this.SSP_CheckboxEnableServer.Size = new System.Drawing.Size(15, 14);
            this.SSP_CheckboxEnableServer.TabIndex = 16;
            this.SSP_CheckboxEnableServer.UseVisualStyleBackColor = true;
            // 
            // SSP_ComboBoxServerType
            // 
            this.SSP_ComboBoxServerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_ComboBoxServerType.FormattingEnabled = true;
            this.SSP_ComboBoxServerType.Location = new System.Drawing.Point(184, 38);
            this.SSP_ComboBoxServerType.Name = "SSP_ComboBoxServerType";
            this.SSP_ComboBoxServerType.Size = new System.Drawing.Size(532, 23);
            this.SSP_ComboBoxServerType.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "No Action",
            "Reset Data",
            "No Data"});
            this.comboBox2.Location = new System.Drawing.Point(187, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(529, 23);
            this.comboBox2.TabIndex = 13;
            // 
            // ServerSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 250);
            this.Controls.Add(this.SSP_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerSettingsPanel";
            this.Text = "GeneralSettingsPanel";
            this.SSP_MainPanel.ResumeLayout(false);
            this.SSP_TableLayout.ResumeLayout(false);
            this.SSP_TableLayout.PerformLayout();
            this.SSP_TablePasswordSettings.ResumeLayout(false);
            this.SSP_TablePasswordSettings.PerformLayout();
            this.SSP_TableMasterServer.ResumeLayout(false);
            this.SSP_TableMasterServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SSP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel SSP_TableLayout;
        private System.Windows.Forms.Label SSP_LabelEnableServer;
        private System.Windows.Forms.Label SSP_LabelServerType;
        private System.Windows.Forms.Label SSP_LabelGameType;
        private System.Windows.Forms.TextBox SSP_TextBoxGameType;
        private System.Windows.Forms.Label SSP_LabelMasterServer;
        private System.Windows.Forms.ToolTip GSP_MasterToolTip;
        private System.Windows.Forms.Label SSP_LabelServerPassword;
        private System.Windows.Forms.TableLayoutPanel SSP_TablePasswordSettings;
        private System.Windows.Forms.CheckBox SSP_CheckboxEnablePassword;
        private System.Windows.Forms.TextBox SSP_TextboxPassword;
        private System.Windows.Forms.TableLayoutPanel SSP_TableMasterServer;
        private System.Windows.Forms.CheckBox SSP_CheckBoxPublicBroadCast;
        private System.Windows.Forms.ComboBox SSP_ComboPublicRoomType;
        private System.Windows.Forms.Label SSP_LabelPreventAddonUpload;
        private System.Windows.Forms.CheckBox SSP_CheckboxPreventAddonUpload;
        private System.Windows.Forms.CheckBox SSP_CheckboxEnableServer;
        private System.Windows.Forms.ComboBox SSP_ComboBoxServerType;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}