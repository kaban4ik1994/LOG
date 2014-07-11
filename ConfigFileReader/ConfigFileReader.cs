using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Settings;
using Yaml_Reader;

namespace ConfigFileReader
{
    public class ConfigFileReader
    {
        public Settings.Settings Settings { get; set; }

        public ConfigFileReader(string filePath)
        {
            var yamlReader = new YamlReader(filePath);

            Settings = new Settings.Settings
            {
                AvailableMethods = new List<KeyValuePair<string, int>>(),
                AvailableProtocols = new List<KeyValuePair<string, int>>(),
                AvailableFileExtension = new List<KeyValuePair<string, int>>(),
                AvailableStatusСodes = new List<KeyValuePair<string, int>>()
            };

            for (var i = 0; i < yamlReader.Records.Count(); i++)
            {
                if (yamlReader.Records.ElementAt(i).Key1 == "Method")
                {
                    Settings.AvailableMethods.Add(new KeyValuePair<string, int>(yamlReader.Records.ElementAt(i).Value1,
                        Convert.ToInt32(yamlReader.Records.ElementAt(i).Value2)));
                }
                if (yamlReader.Records.ElementAt(i).Key1 == "Protocol")
                {
                    Settings.AvailableProtocols.Add(new KeyValuePair<string, int>(yamlReader.Records.ElementAt(i).Value1,
                        Convert.ToInt32(yamlReader.Records.ElementAt(i).Value2)));
                }

                if (yamlReader.Records.ElementAt(i).Key1 == "StatusCode")
                {
                    Settings.AvailableStatusСodes.Add(new KeyValuePair<string, int>(yamlReader.Records.ElementAt(i).Value1,
                        Convert.ToInt32(yamlReader.Records.ElementAt(i).Value2)));
                }

                if (yamlReader.Records.ElementAt(i).Key1 == "FileExtension")
                {
                    Settings.AvailableFileExtension.Add(new KeyValuePair<string, int>(yamlReader.Records.ElementAt(i).Value1,
                        Convert.ToInt32(yamlReader.Records.ElementAt(i).Value2)));
                }
            }
        }

    }
}
