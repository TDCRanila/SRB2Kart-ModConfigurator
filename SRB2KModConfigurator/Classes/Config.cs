using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using SRB2KModConfigurator.Data;

namespace SRB2KModConfigurator.Config
{
    public class SRB2ConfigFile
    {
        public string configurationDisplayName {get; set;}
        public bool enableOverrideSettings { get; set; }

        public string targetFilePath { get; set; }
        public string mainModFolderPath { get; set; }
        public List<string> modFiles { get; set; }
        public ConfigurationSettingsDataStruct configSettingsData {get; set; }

        public SRB2ConfigFile()
        {
            configurationDisplayName    = "";
            enableOverrideSettings      = false;
            targetFilePath              = "";
            mainModFolderPath           = "";
            modFiles                    = new List<string>();
            configSettingsData          = new ConfigurationSettingsDataStruct();
        }

        public string CreateJSONString()
        {
            JsonSerializerOptions options   = new JsonSerializerOptions();
            options.WriteIndented           = true;

            string jsonString = JsonSerializer.Serialize(this, options);
            return jsonString;
        }

        public bool LoadFromJSONString(string loadedJSONString)
        {
            JsonSerializerOptions options   = new JsonSerializerOptions();
            options.WriteIndented           = true;

            try
            {
               SRB2ConfigFile loadedConfigFile = JsonSerializer.Deserialize<SRB2ConfigFile>(loadedJSONString);
                this.configurationDisplayName   = loadedConfigFile.configurationDisplayName;
                this.enableOverrideSettings     = loadedConfigFile.enableOverrideSettings;
                this.targetFilePath             = loadedConfigFile.targetFilePath;
                this.mainModFolderPath          = loadedConfigFile.mainModFolderPath;
                this.modFiles                   = loadedConfigFile.modFiles;
                this.configSettingsData         = loadedConfigFile.configSettingsData;
                return true;
            }
            catch 
            {
                // POP UP: Invalid Configuration / Trying to Load incompatible Configuration.
                MessageBox.Show("Cannot load this file as it is incompatible.", "Loading Invalid Configuration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public string CreateParameterString()
        {
            string parameterString = "";

            using (StringWriter writer = new StringWriter())
            {
                char quationMark    = '"';
                char space          = ' ';

                // Adding Mods
                writer.Write("-file" + space);

                foreach (string modPath in modFiles)
                {
                    writer.Write(quationMark + modPath + quationMark + space);
                }

                /// Bonus Character Pack
                GeneralSettingsDataStruct generalSettings = this.configSettingsData.generalSettings;
                if (generalSettings.shouldAddBonusCharacterPack)
                {
                    DirectoryInfo targetDirInfo = new DirectoryInfo(targetFilePath);
                    FileInfo[] files            = targetDirInfo.Parent.GetFiles();
                    foreach(FileInfo file in files)
                    {
                        if (file.Name == "bonuschars.kart")
                        {
                            writer.Write(quationMark +  file.FullName + quationMark + space);
                            break;
                        }
                    }
                }

                if (this.enableOverrideSettings)
                {
                    // General Override Settings 
                    /// Bonus Characters
                    if (generalSettings.shouldAddBonusCharacterPack)
                    {
                        // Done during mod file parsing above.
                    }

                    /// Skip Game Intro
                    if (generalSettings.shouldSkipGameIntro)
                    {
                        writer.Write("-skipintro" + space);
                    }

                    /// Data Action
                    switch(generalSettings.dataAction)
                    {
                        case DataAction.NoOverride:
                        {
                            break;
                        }
                        case DataAction.LoadWithNoData:
                        {
                            writer.Write("-nodata" + space);
                            break;
                        }
                        case DataAction.ResetExistingData:
                        {
                            writer.Write("-resetdata" + space);
                            break;
                        }
                        default:
                        {
                            break;  
                        }
                    }

                    /// Addition Console
                    if (generalSettings.enableAdditionalConsole)
                    {
                        writer.Write("-console" + space);
                    }

                    /// Custom Config File
                    if (generalSettings.enableAdditionalConsole)
                    {
                        writer.Write("-config" + space + generalSettings.customConfigFilePath + space);
                    }

                    /// Additional Commandline Parameters
                    if (generalSettings.additionalCommandlineParameters.Length != 0)
                    {
                        writer.Write(generalSettings.additionalCommandlineParameters);
                    }

                    // Video Override Settings
                    VideoSettingsDataStruct videoSettings = this.configSettingsData.videoSettings;
                    /// Window Mode
                    if (videoSettings.overrideWindowMode)
                    {
                        switch (videoSettings.windowMode)
                        {
                            case WindowMode.NoOverride:
                            {
                                break;
                            }
                            case WindowMode.Fullscreen:
                            {
                                writer.Write("+fullscreen" + space + "Yes" + space);
                                break;
                            }
                            case WindowMode.Windowed:
                            {
                                writer.Write("-win" + space + "+fullscreen" + space + "No" + space);
                                break;
                            }
                        }
                    }

                    /// Renderer Type
                    if (videoSettings.overrideRendererType)
                    {
                        switch (videoSettings.rendererType)
                        {
                            case RendererType.OpenGL2DSprites:
                            {
                                writer.Write("-opengl" + space + "+gr_mdls" + space + "No" + space);
                                break;
                            }
                            case RendererType.OpenGL3DModels:
                            {
                                writer.Write("-opengl" + space + "+gr_mdls" + space + "Yes" + space);
                                break;
                            }
                            case RendererType.Software:
                            {
                                writer.Write("-software");
                                break;
                            }
                        }
                    }

                    /// Render Resolution
                    if (videoSettings.overrideRenderResolution)
                    {
                        writer.Write("-width" + space + videoSettings.resolutionWidth + space + "-height" + space + videoSettings.resolitionHeight + space);
                    }

                    // Audio Override Settings
                    AudioSettingsDataStruct audioSettings = this.configSettingsData.audioSettings;
                    /// No Music
                    if (audioSettings.disableMusic)
                    {
                        writer.Write("-nomusic" + space);
                    }

                    /// No SFXs
                    if (audioSettings.disableSFXs)
                    {
                        writer.Write("-nosound" + space);
                    }

                    // Server Settings
                    ServerSettingsDataStruct serverSettings = this.configSettingsData.serverSettings;
                    switch (serverSettings.onlineMode)
                    {

                        //-// Offline Mode
                        case OnlineModeType.Offline:
                        {
                            break;
                        }

                        //-// Online Mode
                        case OnlineModeType.JoinServer:
                        {
                            /// Server IP
                            writer.Write("-connect" + serverSettings.serverJoinIP + space);

                            /// Server Port
                            if (serverSettings.serverJoinPort.Length != 0)
                            {
                                writer.Write("-port" + serverSettings.serverJoinPort + space);
                            }

                            /// Prevent Addon Download
                            if (serverSettings.serverJoinPreventDownload)
                                writer.Write("-nodownload" + space);

                            break;
                        }

                        //-// Server Mode
                        case OnlineModeType.HostServer:
                        {
                            /// Server Name
                            writer.Write("+servername" + space + serverSettings.serverHostName + space);

                            /// Server Type
                            if      (serverSettings.serverHostType == ServerType.ClientServer)
                            {
                                    writer.Write("-server" + space);
                            }
                            else if (serverSettings.serverHostType == ServerType.DedicatedServer)
                            {
                                    writer.Write("-dedicated" + space);
                            }

                            /// Server Password
                            if (serverSettings.enableServerHostPassword && serverSettings.serverHostPassword.Length != 0)
                            {
                                writer.Write("-password" + space + serverSettings.serverHostPassword + space);
                            }

                            /// Server BroadcastType
                            if (serverSettings.enableServerHostBroadcastType)
                            {
                                if (serverSettings.serverHostBroadcastType == ServerBroadcastType.Casual)
                                {
                                        writer.Write("-room 28" + space);
                                }
                                else
                                {
                                        writer.Write("-room 33" + space);
                                }
                            }

                            /// Server Game Type
                            if (serverSettings.serverHostGameType.Length != 0)
                            {
                                writer.Write(serverSettings.serverHostGameType + space);
                            }

                            /// Prevent Addon Upload
                            if (serverSettings.serverHostPreventUpload)
                            {
                                writer.Write("-noupload" + space);
                            }
                            
                            break;
                        }
                    }
                }

                // End
                parameterString = writer.ToString();
            }

            return parameterString;
        }

        public string CreateLauncherString()
        {
            string launcherString = "";
            using (StringWriter writer = new StringWriter())
            {
                char quationMark    = '"';
                char space          = ' ';
                char newLine        = '\n';

                // Echo
                writer.Write("@echo off " + newLine);

                // Name
                writer.Write("::Config: " + space + this.configurationDisplayName + newLine);

                // Exe
                writer.Write("start" + space + quationMark + quationMark + space);
                writer.Write(quationMark + targetFilePath + quationMark + space);

                // Parameters
                writer.Write(CreateParameterString());

                // Exit
                writer.Write(newLine);
                writer.Write("exit");

                launcherString = writer.ToString();
            }

            return launcherString;
        }
    }

} // End of namespace ~ SRB2KModConfigurator.Config
