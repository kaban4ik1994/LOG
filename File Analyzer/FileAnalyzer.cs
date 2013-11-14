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

        public DateTime GetMinimumDate()
        {
            var result=_recordList[0].Date;
            for (var i = 1; i < _recordList.Count; i++)
            {
                if (DateTime.Compare(result, _recordList[i].Date) > 0)
                {
                    result = _recordList[i].Date;
                }
            }

            return result;
        }

        public DateTime GetMaximumDate()
        {
            var result = _recordList[0].Date;
            for (var i = 1; i < _recordList.Count; i++)
            {
                if (DateTime.Compare(result, _recordList[i].Date) < 0)
                {
                    result = _recordList[i].Date;
                }
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
                if (value.StatusCode == valueName) count++;
            }
            return count/_recordList.Count;
        }

        public StringBuilder GetLines(DateTime startDate, DateTime endDate)
        {

            var result=new StringBuilder();
            if (startDate == Convert.ToDateTime(null) && endDate == Convert.ToDateTime(null)) return result;
            if (startDate == Convert.ToDateTime(null)) startDate = GetMinimumDate();
            if (endDate == Convert.ToDateTime(null)) endDate = GetMaximumDate();
            var converter = new ConvertItemToString();
            foreach (var record in _recordList.Where(record => ((DateTime.Compare(startDate, record.Date) < 0) ||
                                                                (DateTime.Compare(startDate, record.Date) == 0)) &&
                                                               ((DateTime.Compare(endDate, record.Date) > 0) ||
                                                                (DateTime.Compare(endDate, record.Date) == 0))))
            {
                result.AppendLine(converter.ConvertToString(record));
            }

            return result;
        }

        public StringBuilder GetUniqueIp()
        {
            var result=new StringBuilder();
            for (var i=0; i<_recordList.Count; i++)
            {
                for (var j = 0; j < _recordList.Count; j++)
                {
                    if ((_recordList[i].IpByte1 == _recordList[j].IpByte1) &&
                        (_recordList[i].IpByte2 == _recordList[j].IpByte2) &&
                        (_recordList[i].IpByte3 == _recordList[j].IpByte3) &&
                        (_recordList[i].IpByte4 == _recordList[j].IpByte4)&&(i!=j))
                    {
                        break;
                    }
                    if (j == _recordList.Count-1)
                    {
                        result.AppendLine(string.Format("{0}.{1}.{2}.{3}", _recordList[i].IpByte1,
                            _recordList[i].IpByte2, _recordList[i].IpByte3, _recordList[i].IpByte4));
                    }

                }
            }
            return result;
        }
    }
}
