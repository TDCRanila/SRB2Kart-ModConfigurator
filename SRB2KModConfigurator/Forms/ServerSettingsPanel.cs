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
            SSP_CheckboxHostServerEnablePassword.Checked        = data.enableServerHostPassword;
            SSP_TextboxHostServerPassword.Text                  = data.serverHostPassword;
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
            data.serverJoinIP                   = SSP_TextboxJoinServerIP.Text;
            data.serverJoinPort                 = SSP_TextboxJoinServerPort.Text;
            data.serverJoinPreventDownload      = SSP_CheckboxJoinServerPreventAddonDownload.Checked;

            data.serverHostName                 = SSP_TextboxHostServerName.Text;
            data.serverHostType                 = (ServerType)Enum.Parse(typeof(ServerType), SSP_ComboboxHostServerType.SelectedItem.ToString());
            data.enableServerHostPassword       = SSP_CheckboxHostServerEnablePassword.Checked;
            data.serverHostPassword             = SSP_TextboxHostServerPassword.Text;
            data.enableServerHostBroadcastType  = SSP_CheckboxHostServerPublicBroadCast.Checked;
            data.serverHostBroadcastType        = (ServerBroadcastType)Enum.Parse(typeof(ServerBroadcastType), SSP_ComboboxHostServerPublicBroadcast.SelectedItem.ToString());
            data.serverHostGameType             = SSP_TextBoxHostServerGameType.Text;
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
            SSP_CheckboxHostServerEnablePassword.Enabled        = enableServerHostSettings;
            SSP_TextboxHostServerPassword.Enabled               = enableServerHostSettings && SSP_CheckboxHostServerEnablePassword.Checked;
            SSP_CheckboxHostServerPublicBroadCast.Enabled       = enableServerHostSettings;
            SSP_ComboboxHostServerPublicBroadcast.Enabled       = enableServerHostSettings && SSP_CheckboxHostServerPublicBroadCast.Checked;
            SSP_TextBoxHostServerGameType.Enabled               = enableServerHostSettings;
            SSP_CheckboxHostServerPreventAddonUpload.Enabled    = enableServerHostSettings;
        }

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
    }
}
