using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Settings;
using Yaml_Reader;
using Settings;

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
                AvailableMethods = new KeyValuePair<string, int>[yamlReader.Records.Count()],
                AvailableProtocols = new KeyValuePair<string, int>[yamlReader.Records.Count()]
            };

            for (var i = 0; i < yamlReader.Records.Count(); i++)
            {
                if (yamlReader.Records.ElementAt(i).Key1 == "Method")
                {
                    Settings.AvailableMethods[i] = new KeyValuePair<string, int>(yamlReader.Records.ElementAt(i).Value1,
                        Convert.ToInt32(yamlReader.Records.ElementAt(i).Value2));
                }
                if (yamlReader.Records.ElementAt(i).Key1 == "Protocol")
                {
                    Settings.AvailableMethods[i] = new KeyValuePair<string, int>(yamlReader.Records.ElementAt(i).Value1,
                        Convert.ToInt32(yamlReader.Records.ElementAt(i).Value2));
                }
            }
        }

    }
}
