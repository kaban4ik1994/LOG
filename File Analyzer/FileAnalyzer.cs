using System.Collections.Generic;
using System.Linq;
using System.Text;
using Journal_Record;
namespace File_Analyzer
{
    public class FileAnalyzer
    {
        private readonly List<JournalRecord> _eventList;

        public FileAnalyzer(IEnumerable<JournalRecord> eventList)
        {
            _eventList = eventList.ToList();
        }

        public StringBuilder GetLines(int startingLine, int countLine)
        {
            var result = new StringBuilder();
            if (!_eventList.Any()) return result;
            for (var i = startingLine; i < startingLine + countLine; i++)
            {
                result.AppendLine(_eventList.ElementAt(i).ToString());
            }
            return result;
        }
    }
}
