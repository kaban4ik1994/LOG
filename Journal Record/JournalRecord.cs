using System;
using System.Collections.Generic;

namespace Journal_Record
{
    public class JournalRecord:Ip.Ip
    {

        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string Protocol { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string StatusCode { get; set; }
        public int NumberOfBytes { get; set; }


    }
}
