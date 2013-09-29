using System;
using System.IO;
using System.Text;
using Journal_Record;

namespace File_Generator
{
    public class FileGenerator
    {
        private StreamWriter _streamWriter;
        private readonly Random _random = new Random(DateTime.Now.Millisecond);
        private string[] _protocol;
        private string[] _httpMethods;
        private int[] _statusСodes;
        private string[] _fileExtension;
        private DateTime _startTime;
        private int _minIntervalInMilliseconds;
        private int _maxIntervalInMilliseconds;

        public string[] Protocol
        {
            set
            {
                _protocol = value;
            }
        }

        public string[] HttpMethods
        {
            set
            {
                _httpMethods = value;
            }
        }

        public int[] StatusCodes
        {
            set
            {
                _statusСodes = value;
            }
        }

        public string[] FileExtension
        {
            set
            {
                _fileExtension = value;
            }
        }

        public DateTime StartTime
        {
            set
            {
                _startTime = value;
            }
        }

        public int MinIntervalInMilliseconds
        {
            set
            {
                _minIntervalInMilliseconds = value;
            }
        }

        public int MaxIntervalInMilliseconds
        {
            set
            {
                _maxIntervalInMilliseconds = value;
            }
        }

        public void CreateFile(string filePath, int numberLines)
        {
            _streamWriter = new StreamWriter(filePath);
            var result = new StringBuilder();

            for (var i = 0; i < numberLines - 1; i++)
            {
                result.AppendLine(GenerationLine());
            }
            result.Append(GenerationLine());

            _streamWriter.Write(result);
            _streamWriter.Close();
        }

        private string GenerationLine()
        {
            var fileName = string.Empty;
            var ipByte1 = Convert.ToByte(_random.Next(1, 128));
            var ipByte2 = Convert.ToByte(_random.Next(1, 254));
            var ipByte3 = Convert.ToByte(_random.Next(1, 254));
            var ipByte4 = Convert.ToByte(_random.Next(1, 254));
            var date = _startTime;
            _startTime = _startTime.AddMilliseconds(_random.Next(_minIntervalInMilliseconds, _maxIntervalInMilliseconds));
            var method = _httpMethods[_random.Next(0, _httpMethods.Length)];
            var protocol = _protocol[_random.Next(0, _protocol.Length)];
            var fileNameLenght = _random.Next(1, 30);
            for (var i = 0; i < fileNameLenght; i++)
            {
                fileName += Convert.ToChar(_random.Next(97, 122));
            }
            var fileExtension = _fileExtension[_random.Next(0, _fileExtension.Length)];
            var statusCode = _statusСodes[_random.Next(0, _statusСodes.Length)];
            var numberOfBytes = _random.Next(1, 100000);
            var structLine = new JournalRecord(ipByte1, ipByte2, ipByte3, ipByte4, date, method,protocol, fileName, fileExtension,
                 statusCode, numberOfBytes);
            return structLine.ToString();
        }
    }
}

