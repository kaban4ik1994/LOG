using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Journal_Record;
using Ip = Ip.Ip;

namespace File_Generator
{
    public class FileGenerator
    {
        private readonly Random _random = new Random(DateTime.Now.Millisecond);
        private string[] _protocol;
        private string[] _httpMethods;
        private string[] _statusСodes;
        private string[] _fileExtension;
        private DateTime _startTime;
        private int _minIntervalInMilliseconds;
        private int _maxIntervalInMilliseconds;
        private int _minNumberOfBytes;
        private int _maxNumberOfBytes;
        private Settings.Settings _parameters;
        private int _numberOfUniqueIp;
        private readonly List<global::Ip.Ip> _ipList=new List<global::Ip.Ip>();


        public int NumberOfUniqueIp
        {
            set
            {
                _numberOfUniqueIp = value;
            }

        }

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

        public string[] StatusCodes
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

        public int MinNumberOfBytes
        {
            set
            {
                _minNumberOfBytes = value;
            }
        }

        public int MaxNumberOfBytes
        {
            set
            {
                _maxNumberOfBytes = value;
            }
        }

        public Settings.Settings Parameters
        {
            set
            {
                _parameters = value;
            }
        }

        public List<JournalRecord> CreateLogRecords(int numberLines)
        {
            var logRecords = new List<JournalRecord>();
            for (var i = 0; i < numberLines; i++)
            {
                logRecords.Add(GeneratRecord());
            }
            return logRecords;
        }

        private int FindWeightingCoefficientInTheFile(string value, IEnumerable<KeyValuePair<string, int>> availableValues)
        {
            var result = -1;
            foreach (var parameter in availableValues.Where(parameter => parameter.Key == value))
            {
                result = Convert.ToInt32(parameter.Value);
                break;
            }
            return result;
        }

        private int SumOfWeightCoefficient(ICollection<string> arrayOfValues, IEnumerable<KeyValuePair<string, int>> values)
        {
            var availableValues = values as KeyValuePair<string, int>[] ?? values.ToArray();
            var sumOfWeightCoefficients = availableValues.Sum(keyValuePair => keyValuePair.Value); // сумма весовых коэффициентов в массиве

            sumOfWeightCoefficients = arrayOfValues.Where(method => FindWeightingCoefficientInTheFile(method, availableValues) == -1).Aggregate(sumOfWeightCoefficients, (current, method) => current + current / arrayOfValues.Count); //пересчет суммы если есть методы, которые не были описаны в файле конфигурации
            return sumOfWeightCoefficients;
        }

        private string GetRandomValue(IEnumerable<string> arrayOfValues, int sumOfWeightCoefficients, IEnumerable<KeyValuePair<string, int>> available)
        {
            var result = string.Empty;
            var randomWeightCoefficientOfMethods = _random.Next(1, sumOfWeightCoefficients);
            var previousWeightCoefficient = 0;
            var tempWeightCoefficient = 0;
            var keyValuePairs = available as KeyValuePair<string, int>[] ?? available.ToArray();
            foreach (var value in arrayOfValues)
            {
                var weightCoefficient = FindWeightingCoefficientInTheFile(value, keyValuePairs);
                tempWeightCoefficient += weightCoefficient != -1
                    ? weightCoefficient
                    : sumOfWeightCoefficients / keyValuePairs.Length; //если коэффициент не найден, то считаем, что он равен среднему арифметическому среди всех элементов.
                if (randomWeightCoefficientOfMethods <= tempWeightCoefficient &&
                    randomWeightCoefficientOfMethods > previousWeightCoefficient)
                {
                    result = value;
                    break;
                }
                previousWeightCoefficient = tempWeightCoefficient;
            }
            return result;
        }

        private JournalRecord GeneratRecord()
        {
            var fileName = string.Empty;
            var ip=new global::Ip.Ip();
            if (_ipList.Count < _numberOfUniqueIp)
            {
                ip.IpByte1 = Convert.ToByte(_random.Next(1, 128));
                ip.IpByte2 = Convert.ToByte(_random.Next(1, 254));
                ip.IpByte3 = Convert.ToByte(_random.Next(1, 254));
                ip.IpByte4 = Convert.ToByte(_random.Next(1, 254));
                _ipList.Add(ip);
            }
            else
            {
                ip = _ipList.ElementAt(_random.Next(0, _ipList.Count));
            }
            var date = _startTime;
            _startTime = _startTime.AddMilliseconds(_random.Next(_minIntervalInMilliseconds, _maxIntervalInMilliseconds));
            var randomMethod = GetRandomValue(_httpMethods, SumOfWeightCoefficient(_httpMethods, _parameters.AvailableMethods),_parameters.AvailableMethods);
            var protocol = _protocol[_random.Next(0, _protocol.Length)];
            var fileNameLenght = _random.Next(1, 30);
            for (var i = 0; i < fileNameLenght; i++)
            {
                fileName += Convert.ToChar(_random.Next(97, 122));
            }
            var fileExtension = _fileExtension[_random.Next(0, _fileExtension.Length)];
            var statusCode = _statusСodes[_random.Next(0, _statusСodes.Length)];
            var numberOfBytes = _random.Next(_minNumberOfBytes, _maxNumberOfBytes);
            var structLine = new JournalRecord
            {
                IpByte1 = ip.IpByte1,
                IpByte2 = ip.IpByte2,
                IpByte3 = ip.IpByte3,
                IpByte4 = ip.IpByte4,
                Date = date,
                Method = randomMethod,
                Protocol = protocol,
                FileName = fileName,
                FileExtension = fileExtension,
                StatusCode = statusCode,
                NumberOfBytes = numberOfBytes
            };
            return structLine;
        }
    }
}

