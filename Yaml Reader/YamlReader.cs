using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Journal_Configuration;

namespace Yaml_Reader
{
    public class YamlReader
    {
        private readonly IEnumerable<JournalConfiguration> _records;
        public YamlReader(string filePath)
        {
            var lines = new List<string>();
            var readFile = new StreamReader(filePath);
            while (!readFile.EndOfStream)
            {
                lines.Add(readFile.ReadLine());
            }
            _records = ParsLines(lines);
            readFile.Close();
        }

        public IEnumerable<JournalConfiguration> Records
        {
            get { return _records; }
        }

        private static IEnumerable<JournalConfiguration> ParsLines(IEnumerable<string> lines)
        {
            var regex = new Regex(@"\{(?<Key1>\w+)\:(?<Value1>\w+)\,(?<Key2>\w+)\:(?<Value2>\w+)\}");
            var result =
                from line in lines
                let values = regex.Match(line)
                where (values.Length != 0)
                select
                (
                 new JournalConfiguration
            {
                Key1 = values.Groups[1].Value,
                Value1 = values.Groups[2].Value,
                Key2 = values.Groups[3].Value,
                Value2 = values.Groups[4].Value
            }
                );
            return result;
        }
    }
}
