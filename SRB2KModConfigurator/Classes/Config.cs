using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Text.Json;
using System.Text.Json.Serialization;

using SRB2KModConfigurator.Data;

namespace SRB2KModConfigurator.Config
{
    public class SRB2ConfigFile
    {
        public SRB2ConfigFile()
        {
            configurationDisplayName    = "";
            enableOverrideSettings      = false;
            targetFilePath              = "";
            mainModFolderPath           = "";
            modFiles                    = new List<string>();
            configSettingsData          = new ConfigurationSettingsDataStruct();
        }

        public string configurationDisplayName {get; set;}
        public bool enableOverrideSettings { get; set; }

        public string targetFilePath { get; set; }
        public string mainModFolderPath { get; set; }
        public List<string> modFiles { get; set; }

        public ConfigurationSettingsDataStruct configSettingsData {get; set; }

        public string CreateJSONString()
        {
            JsonSerializerOptions options   = new JsonSerializerOptions();
            options.WriteIndented           = true;

            string jsonString = JsonSerializer.Serialize(this, options);
            return jsonString;
        }

        public void LoadFromJSONString(string loadedJSONString)
        {
            JsonSerializerOptions options   = new JsonSerializerOptions();
            options.WriteIndented           = true;

            SRB2ConfigFile loadedConfigFile = JsonSerializer.Deserialize<SRB2ConfigFile>(loadedJSONString);

            this.configurationDisplayName   = loadedConfigFile.configurationDisplayName;
            this.enableOverrideSettings     = loadedConfigFile.enableOverrideSettings;
            this.targetFilePath             = loadedConfigFile.targetFilePath;
            this.mainModFolderPath          = loadedConfigFile.mainModFolderPath;
            this.modFiles                   = loadedConfigFile.modFiles;
            this.configSettingsData         = loadedConfigFile.configSettingsData;
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

                // Exe
                writer.Write("start" + space + quationMark + quationMark + space);
                writer.Write(quationMark + targetFilePath + quationMark + space);

                // Parameters
                /// Video
                writer.Write("-opengl" + space);

                // Adding Mods
                writer.Write("-file" + space);

                foreach (string modPath in modFiles)
                {
                    writer.Write(quationMark + modPath + quationMark + space);
                }
                writer.Write(newLine);

                // Exit
                writer.Write("exit");

                launcherString = writer.ToString();
            }

            return launcherString;
        }
    }

} // End of namespace ~ SRB2KModConfigurator.Config
