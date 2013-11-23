using System.Collections.Generic;

namespace Settings
{
    public  class Settings
    {
        public List<KeyValuePair<string, int>> AvailableMethods { get; set; }
        public List<KeyValuePair<string, int>> AvailableProtocols { get; set; }
        public List<KeyValuePair<string, int>> AvailableStatusСodes { get; set; }
        public List<KeyValuePair<string, int>> AvailableFileExtension { get; set; } 
    }
}
