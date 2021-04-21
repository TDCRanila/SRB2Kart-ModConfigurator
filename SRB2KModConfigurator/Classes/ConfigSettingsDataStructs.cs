using System;

namespace SRB2KModConfigurator.Data
{
    public enum DataAction
    {
        None = 0,
        NoAction,
        NoData,
        ResetExistingData
    };

    public enum WindowMode
    {
        None = 0,
        Fullscreen,
        Windowed
    };

    public enum RenderMode
    {
        None = 0,
        OpenGL,
        Software
    };

    public enum ServerType
    {
        None        = 0,
        Dedicated,
        ClientServer
    };

    public struct GeneralSettingsDataStruct
    {
        public string displayConfigName { get; set; }
        public bool shouldAddBonusCharacterPack { get; set; }
        public bool shouldSkipGameIntro { get; set; }
        public string additionalConfigString { get; set; }
        public DataAction dataAction { get; set; }
        public bool enableAdditionalConsole { get; set; }
    }

    public struct VideoSettingsDataStruct
    {
        public WindowMode windowMode { get; set; }
        public RenderMode renderMode { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public struct AudioSettingsDataStruct
    {
        public bool disableMusic { get; set; }
        public bool disableSFXs { get; set; }
    }

    public struct ServerSettingsDataStruct
    {
        public bool        enableServer { get; set; }
        public ServerType  serverType { get; set; } // 1-dedicated, 2-clientserver
        public string      serverPassword { get; set; }
        public bool        broadcastToMasterServer { get; set; }
        public int         gameType { get; set; }
        public bool        shouldPreventAddonUpload { get; set; }
    }

    public struct ConfigurationSettingsDataStruct
    {
        public GeneralSettingsDataStruct    generalSettings { get; set; }
        public VideoSettingsDataStruct      videoSettings { get; set; }
        public AudioSettingsDataStruct      audioSettings { get; set; }
        public ServerSettingsDataStruct     serverSettings { get; set; }

    };
}
