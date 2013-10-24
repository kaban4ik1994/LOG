using System;

namespace Journal_Record
{
    public class JournalRecord
    {
        public byte IpByte1 { get; set; }
        public byte IpByte2 { get; set; }
        public byte IpByte3 { get; set; }
        public byte IpByte4 { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
        public string Protocol { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int StatusCode { get; set; }
        public int NumberOfBytes { get; set; }


    }
}
