using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Journal_Record;
namespace LOG
{
    public class LogReader
    {
        private readonly IEnumerable<JournalRecord> _eventList;

        public LogReader(string filePath)
        {
            var lines = new List<string>();
            var readFile = new StreamReader(filePath);
            while (!readFile.EndOfStream)
            {
                lines.Add(readFile.ReadLine());
            }
            _eventList = ParsLines(lines);
            readFile.Close();
        }

        public IEnumerable<JournalRecord> EventList
        {
            get { return _eventList; }
        }

        private static IEnumerable<JournalRecord> ParsLines(IEnumerable<string> lines)
        {
            var regex =
                new Regex(
                    @"(?<IpByte1>\d{1,3})\.(?<IpByte2>\d{1,3})\.(?<IpByte3>\d{1,3})\.(?<IpByte4>\d{1,3})\ \-\ \- \[(?<Day>\d{1,2})\/(?<Month>\d{1,2})\/(?<Year>\d{4})\:(?<Hour>\d{1,2})\:(?<Minutes>\d{1,2})\:(?<Seconds>\d{1,2})\]\ (?<Method>\w+)\ (?<Protocol>\w+)\:\/\/(?<filename>\w+)(?<FileFormat>\.\w+)\ (?<StatusCode>\w+)\ (?<NumberOfBytes>\d+)");
            var result =
                from line in lines
                let values = regex.Match(line)
                where (values.Length != 0)
                select
                    (
                        new JournalRecord
                        {
                            IpByte1 = Convert.ToByte(values.Groups[1].Value),
                            IpByte2 = Convert.ToByte(values.Groups[2].Value),
                            IpByte3 = Convert.ToByte(values.Groups[3].Value),
                            IpByte4 = Convert.ToByte(values.Groups[4].Value),
                            Date =
                                new DateTime(Convert.ToInt32(values.Groups[7].Value),
                                    Convert.ToInt32(values.Groups[6].Value),
                                    Convert.ToInt32(values.Groups[5].Value),
                                    Convert.ToInt32(values.Groups[8].Value),
                                    Convert.ToInt32(values.Groups[9].Value),
                                    Convert.ToInt32(values.Groups[10].Value)),
                            Method = values.Groups[11].Value,
                            Protocol = values.Groups[12].Value,
                            FileName = values.Groups[13].Value,
                            FileExtension = values.Groups[14].Value,
                            StatusCode = values.Groups[15].Value,
                            NumberOfBytes = Convert.ToInt32(values.Groups[16].Value)
                        }
                    );


            return result;
        }


    }
}
