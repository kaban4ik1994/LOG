using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaml_Reader
{
    public class YamlReader
    {
        public YamlReader(string filePath)
        {
            IDictionary<string,IDictionary<string,string>> yaml=new Dictionary<string, IDictionary<string, string>>();
            var readFile=new StreamReader(filePath);
            var lines = new List<string>();
            while (!readFile.EndOfStream)
            {
                lines.Add(readFile.ReadLine());
            }
            ParsingFile(lines);
        }

        private IDictionary<string, IDictionary<string, string>> ParsingFile(IEnumerable<string> lines)
        {
            IDictionary<string,IDictionary<string,string>> result=new Dictionary<string, IDictionary<string, string>>();
            foreach (var line in lines)
            {
               
            }   
        }
    }
}
