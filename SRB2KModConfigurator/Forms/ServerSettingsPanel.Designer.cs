
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSettingsPanel));
            this.SSP_MainPanel = new System.Windows.Forms.Panel();
            this.SSP_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SSP_LabelHostServerType = new System.Windows.Forms.Label();
            this.SSP_ComboboxHostServerType = new System.Windows.Forms.ComboBox();
            this.SSP_TextboxHostServerName = new System.Windows.Forms.TextBox();
            this.SSP_CheckboxJoinServerPreventAddonDownload = new System.Windows.Forms.CheckBox();
            this.SSP_LabelJoinServerPreventAddonDownload = new System.Windows.Forms.Label();
            this.SSP_LabelOnlineMode = new System.Windows.Forms.Label();
            this.SSP_ComboboxOnlineMode = new System.Windows.Forms.ComboBox();
            this.SSP_LabelJoinServerIP = new System.Windows.Forms.Label();
            this.SSP_TextboxJoinServerPort = new System.Windows.Forms.TextBox();
            this.SSP_TextboxJoinServerIP = new System.Windows.Forms.TextBox();
            this.SSP_LabelJoinServerPort = new System.Windows.Forms.Label();
            this.SSP_LabelHostServerName = new System.Windows.Forms.Label();
            this.SSP_LabelHostPreventAddonUpload = new System.Windows.Forms.Label();
            this.SSP_CheckboxHostServerPreventAddonUpload = new System.Windows.Forms.CheckBox();
            this.SSP_LabelHostServerGameType = new System.Windows.Forms.Label();
            this.SSP_TextBoxHostServerGameType = new System.Windows.Forms.TextBox();
            this.SSP_LabelHostServerBroadcasting = new System.Windows.Forms.Label();
            this.SSP_TableMasterServer = new System.Windows.Forms.TableLayoutPanel();
            this.SSP_ComboboxHostServerPublicBroadcast = new System.Windows.Forms.ComboBox();
            this.SSP_CheckboxHostServerPublicBroadCast = new System.Windows.Forms.CheckBox();
            this.SSP_TableHostServerPasswordSettings = new System.Windows.Forms.TableLayoutPanel();
            this.SSP_CheckboxHostServerEnablePassword = new System.Windows.Forms.CheckBox();
            this.SSP_TextboxHostServerPassword = new System.Windows.Forms.TextBox();
            this.SSP_LabelHostServerPassword = new System.Windows.Forms.Label();
            this.SSP_MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SSP_MainPanel.SuspendLayout();
            this.SSP_TableLayout.SuspendLayout();
            this.SSP_TableMasterServer.SuspendLayout();
            this.SSP_TableHostServerPasswordSettings.SuspendLayout();
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
            this.SSP_MainPanel.Size = new System.Drawing.Size(720, 370);
            this.SSP_MainPanel.TabIndex = 0;
            // 
            // SSP_TableLayout
            // 
            this.SSP_TableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SSP_TableLayout.ColumnCount = 2;
            this.SSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.43F));
            this.SSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57F));
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelHostServerType, 0, 7);
            this.SSP_TableLayout.Controls.Add(this.SSP_ComboboxHostServerType, 1, 7);
            this.SSP_TableLayout.Controls.Add(this.SSP_TextboxHostServerName, 0, 6);
            this.SSP_TableLayout.Controls.Add(this.SSP_CheckboxJoinServerPreventAddonDownload, 1, 4);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelJoinServerPreventAddonDownload, 0, 4);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelOnlineMode, 0, 0);
            this.SSP_TableLayout.Controls.Add(this.SSP_ComboboxOnlineMode, 1, 0);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelJoinServerIP, 0, 2);
            this.SSP_TableLayout.Controls.Add(this.SSP_TextboxJoinServerPort, 1, 3);
            this.SSP_TableLayout.Controls.Add(this.SSP_TextboxJoinServerIP, 1, 2);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelJoinServerPort, 0, 3);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelHostServerName, 0, 6);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelHostPreventAddonUpload, 0, 11);
            this.SSP_TableLayout.Controls.Add(this.SSP_CheckboxHostServerPreventAddonUpload, 1, 11);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelHostServerGameType, 0, 10);
            this.SSP_TableLayout.Controls.Add(this.SSP_TextBoxHostServerGameType, 1, 10);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelHostServerBroadcasting, 0, 9);
            this.SSP_TableLayout.Controls.Add(this.SSP_TableMasterServer, 1, 9);
            this.SSP_TableLayout.Controls.Add(this.SSP_TableHostServerPasswordSettings, 1, 8);
            this.SSP_TableLayout.Controls.Add(this.SSP_LabelHostServerPassword, 0, 8);
            this.SSP_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SSP_TableLayout.Location = new System.Drawing.Point(0, 0);
            this.SSP_TableLayout.Name = "SSP_TableLayout";
            this.SSP_TableLayout.RowCount = 12;
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SSP_TableLayout.Size = new System.Drawing.Size(720, 370);
            this.SSP_TableLayout.TabIndex = 0;
            // 
            // SSP_LabelHostServerType
            // 
            this.SSP_LabelHostServerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelHostServerType.AutoSize = true;
            this.SSP_LabelHostServerType.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelHostServerType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelHostServerType.Location = new System.Drawing.Point(4, 209);
            this.SSP_LabelHostServerType.Name = "SSP_LabelHostServerType";
            this.SSP_LabelHostServerType.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelHostServerType.TabIndex = 30;
            this.SSP_LabelHostServerType.Text = "Server Type";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelHostServerType, resources.GetString("SSP_LabelHostServerType.ToolTip"));
            // 
            // SSP_ComboboxHostServerType
            // 
            this.SSP_ComboboxHostServerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_ComboboxHostServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSP_ComboboxHostServerType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SSP_ComboboxHostServerType.FormattingEnabled = true;
            this.SSP_ComboboxHostServerType.Items.AddRange(new object[] {
            "ClientServer",
            "DedicatedServer"});
            this.SSP_ComboboxHostServerType.Location = new System.Drawing.Point(187, 205);
            this.SSP_ComboboxHostServerType.Name = "SSP_ComboboxHostServerType";
            this.SSP_ComboboxHostServerType.Size = new System.Drawing.Size(529, 23);
            this.SSP_ComboboxHostServerType.TabIndex = 29;
            // 
            // SSP_TextboxHostServerName
            // 
            this.SSP_TextboxHostServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextboxHostServerName.Location = new System.Drawing.Point(187, 169);
            this.SSP_TextboxHostServerName.Name = "SSP_TextboxHostServerName";
            this.SSP_TextboxHostServerName.Size = new System.Drawing.Size(529, 23);
            this.SSP_TextboxHostServerName.TabIndex = 28;
            this.SSP_TextboxHostServerName.TextChanged += new System.EventHandler(this.SSP_TextboxHostServerName_TextChanged);
            // 
            // SSP_CheckboxJoinServerPreventAddonDownload
            // 
            this.SSP_CheckboxJoinServerPreventAddonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_CheckboxJoinServerPreventAddonDownload.AutoSize = true;
            this.SSP_CheckboxJoinServerPreventAddonDownload.Location = new System.Drawing.Point(187, 126);
            this.SSP_CheckboxJoinServerPreventAddonDownload.Name = "SSP_CheckboxJoinServerPreventAddonDownload";
            this.SSP_CheckboxJoinServerPreventAddonDownload.Size = new System.Drawing.Size(529, 14);
            this.SSP_CheckboxJoinServerPreventAddonDownload.TabIndex = 27;
            this.SSP_CheckboxJoinServerPreventAddonDownload.UseVisualStyleBackColor = true;
            // 
            // SSP_LabelJoinServerPreventAddonDownload
            // 
            this.SSP_LabelJoinServerPreventAddonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelJoinServerPreventAddonDownload.AutoSize = true;
            this.SSP_LabelJoinServerPreventAddonDownload.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelJoinServerPreventAddonDownload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelJoinServerPreventAddonDownload.Location = new System.Drawing.Point(4, 119);
            this.SSP_LabelJoinServerPreventAddonDownload.Name = "SSP_LabelJoinServerPreventAddonDownload";
            this.SSP_LabelJoinServerPreventAddonDownload.Size = new System.Drawing.Size(176, 28);
            this.SSP_LabelJoinServerPreventAddonDownload.TabIndex = 26;
            this.SSP_LabelJoinServerPreventAddonDownload.Text = "Prevent Add-on Download";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelJoinServerPreventAddonDownload, resources.GetString("SSP_LabelJoinServerPreventAddonDownload.ToolTip"));
            // 
            // SSP_LabelOnlineMode
            // 
            this.SSP_LabelOnlineMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelOnlineMode.AutoSize = true;
            this.SSP_LabelOnlineMode.Font = new System.Drawing.Font("envypn7x15", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelOnlineMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelOnlineMode.Location = new System.Drawing.Point(4, 10);
            this.SSP_LabelOnlineMode.Name = "SSP_LabelOnlineMode";
            this.SSP_LabelOnlineMode.Size = new System.Drawing.Size(176, 16);
            this.SSP_LabelOnlineMode.TabIndex = 21;
            this.SSP_LabelOnlineMode.Text = "Online Mode";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelOnlineMode, resources.GetString("SSP_LabelOnlineMode.ToolTip"));
            // 
            // SSP_ComboboxOnlineMode
            // 
            this.SSP_ComboboxOnlineMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_ComboboxOnlineMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSP_ComboboxOnlineMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SSP_ComboboxOnlineMode.FormattingEnabled = true;
            this.SSP_ComboboxOnlineMode.Items.AddRange(new object[] {
            "Offline",
            "JoinServer",
            "HostServer"});
            this.SSP_ComboboxOnlineMode.Location = new System.Drawing.Point(187, 6);
            this.SSP_ComboboxOnlineMode.Name = "SSP_ComboboxOnlineMode";
            this.SSP_ComboboxOnlineMode.Size = new System.Drawing.Size(529, 23);
            this.SSP_ComboboxOnlineMode.TabIndex = 20;
            this.SSP_ComboboxOnlineMode.SelectedIndexChanged += new System.EventHandler(this.SSP_ComboboxOnlineMode_SelectedIndexChanged);
            // 
            // SSP_LabelJoinServerIP
            // 
            this.SSP_LabelJoinServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelJoinServerIP.AutoSize = true;
            this.SSP_LabelJoinServerIP.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelJoinServerIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelJoinServerIP.Location = new System.Drawing.Point(4, 57);
            this.SSP_LabelJoinServerIP.Name = "SSP_LabelJoinServerIP";
            this.SSP_LabelJoinServerIP.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelJoinServerIP.TabIndex = 22;
            this.SSP_LabelJoinServerIP.Text = "Server IP";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelJoinServerIP, resources.GetString("SSP_LabelJoinServerIP.ToolTip"));
            // 
            // SSP_TextboxJoinServerPort
            // 
            this.SSP_TextboxJoinServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextboxJoinServerPort.Location = new System.Drawing.Point(187, 87);
            this.SSP_TextboxJoinServerPort.Name = "SSP_TextboxJoinServerPort";
            this.SSP_TextboxJoinServerPort.Size = new System.Drawing.Size(529, 23);
            this.SSP_TextboxJoinServerPort.TabIndex = 24;
            this.SSP_TextboxJoinServerPort.TextChanged += new System.EventHandler(this.SSP_TextboxJoinServerPort_TextChanged);
            // 
            // SSP_TextboxJoinServerIP
            // 
            this.SSP_TextboxJoinServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextboxJoinServerIP.Location = new System.Drawing.Point(187, 53);
            this.SSP_TextboxJoinServerIP.Name = "SSP_TextboxJoinServerIP";
            this.SSP_TextboxJoinServerIP.Size = new System.Drawing.Size(529, 23);
            this.SSP_TextboxJoinServerIP.TabIndex = 23;
            this.SSP_TextboxJoinServerIP.TextChanged += new System.EventHandler(this.SSP_TextboxJoinServerIP_TextChanged);
            // 
            // SSP_LabelJoinServerPort
            // 
            this.SSP_LabelJoinServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelJoinServerPort.AutoSize = true;
            this.SSP_LabelJoinServerPort.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelJoinServerPort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelJoinServerPort.Location = new System.Drawing.Point(4, 92);
            this.SSP_LabelJoinServerPort.Name = "SSP_LabelJoinServerPort";
            this.SSP_LabelJoinServerPort.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelJoinServerPort.TabIndex = 25;
            this.SSP_LabelJoinServerPort.Text = "Server Port";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelJoinServerPort, resources.GetString("SSP_LabelJoinServerPort.ToolTip"));
            // 
            // SSP_LabelHostServerName
            // 
            this.SSP_LabelHostServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelHostServerName.AutoSize = true;
            this.SSP_LabelHostServerName.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelHostServerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelHostServerName.Location = new System.Drawing.Point(4, 173);
            this.SSP_LabelHostServerName.Name = "SSP_LabelHostServerName";
            this.SSP_LabelHostServerName.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelHostServerName.TabIndex = 18;
            this.SSP_LabelHostServerName.Text = "Server Name";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelHostServerName, "Server Name - Name of the server you are hosting.");
            // 
            // SSP_LabelHostPreventAddonUpload
            // 
            this.SSP_LabelHostPreventAddonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelHostPreventAddonUpload.AutoSize = true;
            this.SSP_LabelHostPreventAddonUpload.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelHostPreventAddonUpload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelHostPreventAddonUpload.Location = new System.Drawing.Point(4, 346);
            this.SSP_LabelHostPreventAddonUpload.Name = "SSP_LabelHostPreventAddonUpload";
            this.SSP_LabelHostPreventAddonUpload.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelHostPreventAddonUpload.TabIndex = 14;
            this.SSP_LabelHostPreventAddonUpload.Text = "Prevent Add-on Upload";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelHostPreventAddonUpload, "Prevent Add-on Upload - Turns off downloading, so the server doesn\'t send files t" +
        "o connecting clients to be downloaded. ");
            // 
            // SSP_CheckboxHostServerPreventAddonUpload
            // 
            this.SSP_CheckboxHostServerPreventAddonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_CheckboxHostServerPreventAddonUpload.AutoSize = true;
            this.SSP_CheckboxHostServerPreventAddonUpload.Location = new System.Drawing.Point(187, 346);
            this.SSP_CheckboxHostServerPreventAddonUpload.Name = "SSP_CheckboxHostServerPreventAddonUpload";
            this.SSP_CheckboxHostServerPreventAddonUpload.Size = new System.Drawing.Size(529, 14);
            this.SSP_CheckboxHostServerPreventAddonUpload.TabIndex = 15;
            this.SSP_CheckboxHostServerPreventAddonUpload.UseVisualStyleBackColor = true;
            // 
            // SSP_LabelHostServerGameType
            // 
            this.SSP_LabelHostServerGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelHostServerGameType.AutoSize = true;
            this.SSP_LabelHostServerGameType.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelHostServerGameType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelHostServerGameType.Location = new System.Drawing.Point(4, 311);
            this.SSP_LabelHostServerGameType.Name = "SSP_LabelHostServerGameType";
            this.SSP_LabelHostServerGameType.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelHostServerGameType.TabIndex = 4;
            this.SSP_LabelHostServerGameType.Text = "Server Game Type";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelHostServerGameType, resources.GetString("SSP_LabelHostServerGameType.ToolTip"));
            // 
            // SSP_TextBoxHostServerGameType
            // 
            this.SSP_TextBoxHostServerGameType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextBoxHostServerGameType.Location = new System.Drawing.Point(187, 307);
            this.SSP_TextBoxHostServerGameType.Name = "SSP_TextBoxHostServerGameType";
            this.SSP_TextBoxHostServerGameType.Size = new System.Drawing.Size(529, 23);
            this.SSP_TextBoxHostServerGameType.TabIndex = 10;
            this.SSP_TextBoxHostServerGameType.TextChanged += new System.EventHandler(this.SSP_TextBoxHostServerGameType_TextChanged);
            // 
            // SSP_LabelHostServerBroadcasting
            // 
            this.SSP_LabelHostServerBroadcasting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelHostServerBroadcasting.AutoSize = true;
            this.SSP_LabelHostServerBroadcasting.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelHostServerBroadcasting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelHostServerBroadcasting.Location = new System.Drawing.Point(4, 270);
            this.SSP_LabelHostServerBroadcasting.Name = "SSP_LabelHostServerBroadcasting";
            this.SSP_LabelHostServerBroadcasting.Size = new System.Drawing.Size(176, 28);
            this.SSP_LabelHostServerBroadcasting.TabIndex = 6;
            this.SSP_LabelHostServerBroadcasting.Text = "Server Public Broadcasting";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelHostServerBroadcasting, resources.GetString("SSP_LabelHostServerBroadcasting.ToolTip"));
            // 
            // SSP_TableMasterServer
            // 
            this.SSP_TableMasterServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TableMasterServer.ColumnCount = 2;
            this.SSP_TableMasterServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SSP_TableMasterServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 529F));
            this.SSP_TableMasterServer.Controls.Add(this.SSP_ComboboxHostServerPublicBroadcast, 1, 0);
            this.SSP_TableMasterServer.Controls.Add(this.SSP_CheckboxHostServerPublicBroadCast, 0, 0);
            this.SSP_TableMasterServer.Location = new System.Drawing.Point(184, 268);
            this.SSP_TableMasterServer.Margin = new System.Windows.Forms.Padding(0);
            this.SSP_TableMasterServer.Name = "SSP_TableMasterServer";
            this.SSP_TableMasterServer.RowCount = 1;
            this.SSP_TableMasterServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SSP_TableMasterServer.Size = new System.Drawing.Size(535, 32);
            this.SSP_TableMasterServer.TabIndex = 13;
            // 
            // SSP_ComboboxHostServerPublicBroadcast
            // 
            this.SSP_ComboboxHostServerPublicBroadcast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_ComboboxHostServerPublicBroadcast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSP_ComboboxHostServerPublicBroadcast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SSP_ComboboxHostServerPublicBroadcast.FormattingEnabled = true;
            this.SSP_ComboboxHostServerPublicBroadcast.Items.AddRange(new object[] {
            "Unlisted",
            "Casual",
            "Standard"});
            this.SSP_ComboboxHostServerPublicBroadcast.Location = new System.Drawing.Point(23, 4);
            this.SSP_ComboboxHostServerPublicBroadcast.Name = "SSP_ComboboxHostServerPublicBroadcast";
            this.SSP_ComboboxHostServerPublicBroadcast.Size = new System.Drawing.Size(523, 23);
            this.SSP_ComboboxHostServerPublicBroadcast.TabIndex = 1;
            // 
            // SSP_CheckboxHostServerPublicBroadCast
            // 
            this.SSP_CheckboxHostServerPublicBroadCast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_CheckboxHostServerPublicBroadCast.AutoSize = true;
            this.SSP_CheckboxHostServerPublicBroadCast.Location = new System.Drawing.Point(3, 3);
            this.SSP_CheckboxHostServerPublicBroadCast.Name = "SSP_CheckboxHostServerPublicBroadCast";
            this.SSP_CheckboxHostServerPublicBroadCast.Size = new System.Drawing.Size(14, 26);
            this.SSP_CheckboxHostServerPublicBroadCast.TabIndex = 0;
            this.SSP_CheckboxHostServerPublicBroadCast.UseVisualStyleBackColor = true;
            this.SSP_CheckboxHostServerPublicBroadCast.CheckedChanged += new System.EventHandler(this.SSP_CheckBoxPublicBroadCast_CheckedChanged);
            // 
            // SSP_TableHostServerPasswordSettings
            // 
            this.SSP_TableHostServerPasswordSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TableHostServerPasswordSettings.ColumnCount = 2;
            this.SSP_TableHostServerPasswordSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SSP_TableHostServerPasswordSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 529F));
            this.SSP_TableHostServerPasswordSettings.Controls.Add(this.SSP_CheckboxHostServerEnablePassword, 0, 0);
            this.SSP_TableHostServerPasswordSettings.Controls.Add(this.SSP_TextboxHostServerPassword, 1, 0);
            this.SSP_TableHostServerPasswordSettings.Location = new System.Drawing.Point(184, 235);
            this.SSP_TableHostServerPasswordSettings.Margin = new System.Windows.Forms.Padding(0);
            this.SSP_TableHostServerPasswordSettings.Name = "SSP_TableHostServerPasswordSettings";
            this.SSP_TableHostServerPasswordSettings.RowCount = 1;
            this.SSP_TableHostServerPasswordSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SSP_TableHostServerPasswordSettings.Size = new System.Drawing.Size(535, 32);
            this.SSP_TableHostServerPasswordSettings.TabIndex = 12;
            // 
            // SSP_CheckboxHostServerEnablePassword
            // 
            this.SSP_CheckboxHostServerEnablePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_CheckboxHostServerEnablePassword.AutoSize = true;
            this.SSP_CheckboxHostServerEnablePassword.Location = new System.Drawing.Point(3, 9);
            this.SSP_CheckboxHostServerEnablePassword.Name = "SSP_CheckboxHostServerEnablePassword";
            this.SSP_CheckboxHostServerEnablePassword.Size = new System.Drawing.Size(14, 14);
            this.SSP_CheckboxHostServerEnablePassword.TabIndex = 0;
            this.SSP_CheckboxHostServerEnablePassword.UseVisualStyleBackColor = true;
            this.SSP_CheckboxHostServerEnablePassword.CheckedChanged += new System.EventHandler(this.SSP_CheckboxEnablePassword_CheckedChanged);
            // 
            // SSP_TextboxHostServerPassword
            // 
            this.SSP_TextboxHostServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_TextboxHostServerPassword.Location = new System.Drawing.Point(23, 4);
            this.SSP_TextboxHostServerPassword.Name = "SSP_TextboxHostServerPassword";
            this.SSP_TextboxHostServerPassword.Size = new System.Drawing.Size(523, 23);
            this.SSP_TextboxHostServerPassword.TabIndex = 1;
            this.SSP_TextboxHostServerPassword.TextChanged += new System.EventHandler(this.SSP_TextboxHostServerPassword_TextChanged);
            this.SSP_TextboxHostServerPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SSP_TextboxHostServerPassword_KeyPress);
            // 
            // SSP_LabelHostServerPassword
            // 
            this.SSP_LabelHostServerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SSP_LabelHostServerPassword.AutoSize = true;
            this.SSP_LabelHostServerPassword.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSP_LabelHostServerPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SSP_LabelHostServerPassword.Location = new System.Drawing.Point(4, 244);
            this.SSP_LabelHostServerPassword.Name = "SSP_LabelHostServerPassword";
            this.SSP_LabelHostServerPassword.Size = new System.Drawing.Size(176, 14);
            this.SSP_LabelHostServerPassword.TabIndex = 11;
            this.SSP_LabelHostServerPassword.Text = "Admin Password";
            this.SSP_MasterToolTip.SetToolTip(this.SSP_LabelHostServerPassword, "Admin Password - Sets the server administrator password, which players can use to" +
        " log in as net-game administrators. ");
            // 
            // SSP_MasterToolTip
            // 
            this.SSP_MasterToolTip.AutoPopDelay = 900000000;
            this.SSP_MasterToolTip.InitialDelay = 500;
            this.SSP_MasterToolTip.IsBalloon = true;
            this.SSP_MasterToolTip.ReshowDelay = 100;
            // 
            // ServerSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 370);
            this.Controls.Add(this.SSP_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServerSettingsPanel";
            this.Text = "ServerSettingsPanel";
            this.SSP_MainPanel.ResumeLayout(false);
            this.SSP_TableLayout.ResumeLayout(false);
            this.SSP_TableLayout.PerformLayout();
            this.SSP_TableMasterServer.ResumeLayout(false);
            this.SSP_TableMasterServer.PerformLayout();
            this.SSP_TableHostServerPasswordSettings.ResumeLayout(false);
            this.SSP_TableHostServerPasswordSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SSP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel SSP_TableLayout;
        private System.Windows.Forms.Label SSP_LabelHostServerGameType;
        private System.Windows.Forms.TextBox SSP_TextBoxHostServerGameType;
        private System.Windows.Forms.Label SSP_LabelHostServerBroadcasting;
        private System.Windows.Forms.ToolTip SSP_MasterToolTip;
        private System.Windows.Forms.Label SSP_LabelHostServerPassword;
        private System.Windows.Forms.TableLayoutPanel SSP_TableHostServerPasswordSettings;
        private System.Windows.Forms.CheckBox SSP_CheckboxHostServerEnablePassword;
        private System.Windows.Forms.TextBox SSP_TextboxHostServerPassword;
        private System.Windows.Forms.TableLayoutPanel SSP_TableMasterServer;
        private System.Windows.Forms.CheckBox SSP_CheckboxHostServerPublicBroadCast;
        private System.Windows.Forms.ComboBox SSP_ComboboxHostServerPublicBroadcast;
        private System.Windows.Forms.Label SSP_LabelHostPreventAddonUpload;
        private System.Windows.Forms.CheckBox SSP_CheckboxHostServerPreventAddonUpload;
        private System.Windows.Forms.Label SSP_LabelHostServerName;
        private System.Windows.Forms.Label SSP_LabelOnlineMode;
        private System.Windows.Forms.ComboBox SSP_ComboboxOnlineMode;
        private System.Windows.Forms.CheckBox SSP_CheckboxJoinServerPreventAddonDownload;
        private System.Windows.Forms.Label SSP_LabelJoinServerPreventAddonDownload;
        private System.Windows.Forms.Label SSP_LabelJoinServerIP;
        private System.Windows.Forms.TextBox SSP_TextboxJoinServerPort;
        private System.Windows.Forms.TextBox SSP_TextboxJoinServerIP;
        private System.Windows.Forms.Label SSP_LabelJoinServerPort;
        private System.Windows.Forms.TextBox SSP_TextboxHostServerName;
        private System.Windows.Forms.Label SSP_LabelHostServerType;
        private System.Windows.Forms.ComboBox SSP_ComboboxHostServerType;
    }
}