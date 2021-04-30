using System;

namespace SRB2KModConfigurator.Data
{
    public enum DataAction
    {
        NoOverride = 0,
        LoadWithNoData,
        ResetExistingData
    };

    public enum WindowMode
    {
        NoOverride = 0,
        Fullscreen,
        Windowed
    };

    public enum RendererType
    {
        NoOverride = 0,
        Software,
        OpenGL,
    };

    public enum RenderResolution
    {
        rNoOverride = 0,
        rCustom,
        r1920X1200rRecommended,
        r1920X1080,
        r1680X1050,
        r1600X1200,
        r1600X900,
        r1366X768,
        r1440X900,
        r1280X1024,
        r1280X960,
        r1280X800rRecommended,
        r1280X720,
        r1152X864,
        r1024X768,
        r800X600,
        r640X400rRecommended,
        r320X240,
        r320X200rRecommended
    };

    public enum OnlineModeType
    {
        Offline = 0,
        JoinServer,
        HostServer,
    }

    public enum ServerType
    {
        ClientServer = 0,
        DedicatedServer,
    };

    public enum ServerBroadcastType
    {
        //Unlisted = 0,
        Casual = 0,
        Standard, 
    }

    public struct GeneralSettingsDataStruct
    {
        public bool shouldAddBonusCharacterPack { get; set; }
        public bool shouldSkipGameIntro { get; set; }
        public DataAction dataAction { get; set; }
        public bool enableAdditionalConsole { get; set; }
        public string customConfigFilePath { get; set; }
        public string additionalCommandlineParameters { get; set; }
    }

    public struct VideoSettingsDataStruct
    {
        public bool overrideWindowMode { get; set; }
        public WindowMode windowMode { get; set; }
        public bool overrideRendererType { get; set; }
        public RendererType rendererType { get; set; }
        public RenderResolution renderResolution { get; set; }
        public bool overrideRenderResolution{ get; set; }
        public int resolutionWidth { get; set; }
        public int resolitionHeight { get; set; }
    }

    public struct AudioSettingsDataStruct
    {
        public bool disableMusic { get; set; }
        public bool disableSFXs { get; set; }
    }

    public struct ServerSettingsDataStruct
    {
        public OnlineModeType       onlineMode { get; set; }
        public string               serverJoinIP { get; set; }
        public string               serverJoinPort { get; set; }
        public bool                 serverJoinPreventDownload { get; set; }

        public string               serverHostName { get; set; }
        public ServerType           serverHostType { get; set; }
        public bool                 enableServerHostPassword { get; set; }
        public string               serverHostPassword { get; set; }
        public bool                 enableServerHostBroadcastType { get; set; }
        public ServerBroadcastType  serverHostBroadcastType { get; set; }
        public string               serverHostGameType { get; set; }
        public bool                 serverHostPreventUpload { get; set; }
    }

    public struct ConfigurationSettingsDataStruct
    {
        public GeneralSettingsDataStruct    generalSettings { get; set; }
        public VideoSettingsDataStruct      videoSettings { get; set; }
        public AudioSettingsDataStruct      audioSettings { get; set; }
        public ServerSettingsDataStruct     serverSettings { get; set; }

    };
}
