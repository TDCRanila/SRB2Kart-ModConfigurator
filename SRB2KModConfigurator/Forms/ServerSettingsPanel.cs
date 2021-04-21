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
        }

        void InitializeSettingControls()
        {
            SSP_ComboBoxServerType.Items.AddRange(Enum.GetNames(typeof(ServerType)));
        }

        public ServerSettingsDataStruct ReturnData()
        {
            ServerSettingsDataStruct data = new ServerSettingsDataStruct();

            bool shouldEnableServer = SSP_CheckboxEnableServer.Checked;
            if (shouldEnableServer)
            {
                data.enableServer   = shouldEnableServer;
                data.serverType     = (ServerType)Enum.Parse(typeof(ServerType), SSP_ComboBoxServerType.SelectedItem.ToString());
                data.serverPassword = SSP_TextboxPassword.Text;

                bool shouldBroadcastToMasterServer = SSP_CheckBoxPublicBroadCast.Checked;
                if (shouldBroadcastToMasterServer)
                {
                    data.broadcastToMasterServer    = shouldBroadcastToMasterServer;
                    // TODO
                    //data.gameType                   = SSP_TextBoxGameType.Text;
                }

                data.shouldPreventAddonUpload   = SSP_CheckboxPreventAddonUpload.Checked;
            }

            return data;
        }
    }
}
