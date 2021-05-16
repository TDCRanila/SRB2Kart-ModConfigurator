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
    public partial class ServerSettingsPanel : Form
    {
        public ServerSettingsPanel()
        {
            InitializeComponent();

            InitializeSettingControls();

            UpdateServerSettingsControls();
        }

        private void InitializeSettingControls()
        {
            SSP_ComboboxHostServerType.Items.Clear();
            SSP_ComboboxHostServerType.Items.AddRange(Enum.GetNames(typeof(ServerType)));

            SSP_ComboboxHostServerPublicBroadcast.Items.Clear();
            SSP_ComboboxHostServerPublicBroadcast.Items.AddRange(Enum.GetNames(typeof(ServerBroadcastType)));

            SSP_ComboboxOnlineMode.SelectedIndex                = 0;
            SSP_ComboboxHostServerPublicBroadcast.SelectedIndex = 0;
            SSP_ComboboxHostServerType.SelectedIndex            = 0;
        }

        public void LoadData(ServerSettingsDataStruct data)
        {
            SSP_ComboboxOnlineMode.SelectedIndex                = (int)data.onlineMode;
            SSP_TextboxJoinServerIP.Text                        = data.serverJoinIP;
            SSP_TextboxJoinServerPort.Text                      = data.serverJoinPort;
            SSP_CheckboxJoinServerPreventAddonDownload.Checked  = data.serverJoinPreventDownload;

            SSP_TextboxHostServerName.Text                      = data.serverHostName;
            SSP_ComboboxHostServerType.SelectedIndex            = (int)data.serverHostType;
            SSP_CheckboxHostServerEnableAdminPassword.Checked   = data.enableServerHostAdminPassword;
            SSP_TextboxHostServerAdminPassword.Text             = data.serverHostAdminPassword;
            SSP_CheckboxHostServerPublicBroadCast.Checked       = data.enableServerHostBroadcastType;
            SSP_ComboboxHostServerPublicBroadcast.SelectedIndex = (int)data.serverHostBroadcastType;
            SSP_TextBoxHostServerGameType.Text                  = data.serverHostGameType;
            SSP_CheckboxHostServerPreventAddonUpload.Checked    = data.serverHostPreventUpload;

            UpdateServerSettingsControls();
        }

        public ServerSettingsDataStruct ReturnData()
        {
            ServerSettingsDataStruct data       = new ServerSettingsDataStruct();

            data.onlineMode                     = (OnlineModeType)Enum.Parse(typeof(OnlineModeType), SSP_ComboboxOnlineMode.SelectedItem.ToString());
            data.serverJoinIP                   = (SSP_TextboxJoinServerIP.Text).TrimEnd();
            data.serverJoinPort                 = (SSP_TextboxJoinServerPort.Text).TrimEnd();
            data.serverJoinPreventDownload      = SSP_CheckboxJoinServerPreventAddonDownload.Checked;

            data.serverHostName                 = (SSP_TextboxHostServerName.Text).TrimEnd();
            data.serverHostType                 = (ServerType)Enum.Parse(typeof(ServerType), SSP_ComboboxHostServerType.SelectedItem.ToString());
            data.enableServerHostAdminPassword  = SSP_CheckboxHostServerEnableAdminPassword.Checked;
            data.serverHostAdminPassword        = (SSP_TextboxHostServerAdminPassword.Text).TrimEnd();
            data.enableServerHostBroadcastType  = SSP_CheckboxHostServerPublicBroadCast.Checked;
            data.serverHostBroadcastType        = (ServerBroadcastType)Enum.Parse(typeof(ServerBroadcastType), SSP_ComboboxHostServerPublicBroadcast.SelectedItem.ToString());
            data.serverHostGameType             = (SSP_TextBoxHostServerGameType.Text).TrimEnd();
            data.serverHostPreventUpload        = SSP_CheckboxHostServerPreventAddonUpload.Checked;

            return data;
        }

        private void UpdateServerSettingsControls()
        {
            OnlineModeType onlineMode = (OnlineModeType)Enum.Parse(typeof(OnlineModeType), SSP_ComboboxOnlineMode.SelectedItem.ToString());

            bool enableServerHostSettings = false;
            bool enableServerJoinSettings = false;

            if (onlineMode == OnlineModeType.Offline)
            {
                enableServerHostSettings = false;
                enableServerJoinSettings = false;
            }

            if (onlineMode == OnlineModeType.JoinServer)
            {
                enableServerHostSettings = false;
                enableServerJoinSettings = true;
            }

            if (onlineMode == OnlineModeType.HostServer)
            {
                enableServerHostSettings = true;
                enableServerJoinSettings = false;
            }

            SSP_TextboxJoinServerIP.Enabled                     = enableServerJoinSettings;
            SSP_TextboxJoinServerPort.Enabled                   = enableServerJoinSettings;
            SSP_CheckboxJoinServerPreventAddonDownload.Enabled  = enableServerJoinSettings;

            SSP_TextboxHostServerName.Enabled                   = enableServerHostSettings;
            SSP_ComboboxHostServerType.Enabled                  = enableServerHostSettings;
            SSP_CheckboxHostServerEnableAdminPassword.Enabled   = enableServerHostSettings;
            SSP_TextboxHostServerAdminPassword.Enabled          = enableServerHostSettings && SSP_CheckboxHostServerEnableAdminPassword.Checked;
            SSP_CheckboxHostServerPublicBroadCast.Enabled       = enableServerHostSettings;
            SSP_ComboboxHostServerPublicBroadcast.Enabled       = enableServerHostSettings && SSP_CheckboxHostServerPublicBroadCast.Checked;
            SSP_TextBoxHostServerGameType.Enabled               = enableServerHostSettings;
            SSP_CheckboxHostServerPreventAddonUpload.Enabled    = enableServerHostSettings;
        }

        #region Callbacks

        private void SSP_CheckboxEnablePassword_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerSettingsControls();
        }

        private void SSP_CheckBoxPublicBroadCast_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServerSettingsControls();
        }

        private void SSP_ComboboxOnlineMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateServerSettingsControls();
        }

        private void SSP_TextboxJoinServerIP_TextChanged(object sender, EventArgs e)
        {
            SSP_TextboxJoinServerIP.Text = (SSP_TextboxJoinServerIP.Text).TrimStart();
        }

        private void SSP_TextboxJoinServerPort_TextChanged(object sender, EventArgs e)
        {
            SSP_TextboxJoinServerPort.Text = (SSP_TextboxJoinServerPort.Text).TrimStart();
        }

        private void SSP_TextboxHostServerName_TextChanged(object sender, EventArgs e)
        {
            SSP_TextboxHostServerName.Text = (SSP_TextboxHostServerName.Text).TrimStart();
        }

        private void SSP_TextboxHostServerPassword_TextChanged(object sender, EventArgs e)
        {
            SSP_TextboxHostServerAdminPassword.Text = (SSP_TextboxHostServerAdminPassword.Text).TrimStart();
        }

        private void SSP_TextboxHostServerPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Password should not accept spaces.
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void SSP_TextBoxHostServerGameType_TextChanged(object sender, EventArgs e)
        {
            SSP_TextBoxHostServerGameType.Text = (SSP_TextBoxHostServerGameType.Text).TrimStart();
        }

        #endregion // End of region ~ Callbacks.

    }
}
