using System;

namespace Journal_Record
{
    public class JournalRecord
    {
        private readonly byte _ipByte1;
        private readonly byte _ipByte2;
        private readonly byte _ipByte3;
        private readonly byte _ipByte4;
        private DateTime _date;
        private readonly string _method;
        private readonly string _protocol;
        private readonly string _fileName;
        private readonly string _fileExtension;
        private readonly int _statusCode;
        private readonly int _numberOfBytes;

        public JournalRecord(byte ipByte1, byte ipByte2, byte ipByte3, byte ipByte4, DateTime date, string method, string protocol, string fileName, string fileExtension, int statusCode, int numberOfBytes)
        {
            _ipByte1 = ipByte1;
            _ipByte2 = ipByte2;
            _ipByte3 = ipByte3;
            _ipByte4 = ipByte4;
            _date = date;
            _method = method;
            _protocol = protocol;
            _fileName = fileName;
            _fileExtension = fileExtension;
            _statusCode = statusCode;
            _numberOfBytes = numberOfBytes;
        }

        public new string ToString()
        {
            var result = string.Format(
                "{0}.{1}.{2}.{3} - - [{4}/{5}/{6}:{7}:{8}:{9}] {10} {11}://{12}{13} {14} {15}",
                _ipByte1, _ipByte2, _ipByte3, _ipByte4, _date.Day, _date.Month, _date.Year, _date.Hour, _date.Minute,
                _date.Second, _method,
                _protocol, _fileName, _fileExtension, _statusCode, _numberOfBytes);
            return result;
        }
    }
}
