using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Journal_Record;
using Convert_Item_To_String;
namespace File_Analyzer
{
    public class FileAnalyzer
    {
        private readonly List<JournalRecord> _recordList;

        public FileAnalyzer(IEnumerable<JournalRecord> eventList)
        {
            _recordList = eventList.ToList();
        }

        public List<int> GetNumberOfBytes()
        {
            return _recordList.Select(t => t.NumberOfBytes).ToList();
        }

        public List<DateTime> GetDate()
        {
            return _recordList.Select(t => t.Date).ToList();
        }

        public StringBuilder GetLines(int startingLine, int countLine)
        {
            var result = new StringBuilder();
            var converter = new ConvertItemToString();
            if (!_recordList.Any()) return result;
            for (var i = startingLine; i < startingLine + countLine; i++)
            {
                result.AppendLine(converter.ConvertToString(_recordList.ElementAt(i)));
            }
            return result;
        }

        public double GetWeightCoefficientOfMethod(string valueName)
        {
            double count = 0;
            foreach (var value in _recordList)
            {
                if (value.Method == valueName) count++;
                if (value.FileExtension == valueName) count++;
                if (value.Protocol == valueName) count++;
            }
            return count/_recordList.Count;
        }
    }
}
