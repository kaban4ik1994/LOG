using System;
using System.Collections.Generic;
using File_Generator.Generator;
using File_Generator.Generator_Param;
using Journal_Record;

namespace File_Generator
{
    public class FileGenerator
    {

        public int MinNumberOfRepeatedIp { get; set; }

        public int MaxNumberOfRepeatedIp { get; set; }

        public int NumberOfUniqueIp { private get; set; }

        public string[] Protocol { get; set; }

        public string[] HttpMethods { get; set; }

        public string[] StatusCodes { get; set; }

        public string[] FileExtension { get; set; }

        public DateTime StartTime { get; set; }

        public int MinIntervalInMilliseconds { get; set; }

        public int MaxIntervalInMilliseconds { get; set; }

        public int MinNumberOfBytes { get; set; }

        public int MaxNumberOfBytes { get; set; }

        public Settings.Settings Parameters { get; set; }

        public int MinLengthOfFileName { get; set; }

        public int MaxLengthOfFileName { get; set; }

        public List<JournalRecord> CreateLogRecords(int numberLines)
        {
            var logRecords = new List<JournalRecord>();
            CreationOptionsValue creationOptionsIp = new CreationOptionsIp
            {
                NumberOfUniqueIp = NumberOfUniqueIp,
                MinNumberOfRepeatedIp = MinNumberOfRepeatedIp,
                MaxNumberOfRepeatedIp = MaxNumberOfRepeatedIp,
                Count = numberLines
            };

            CreationOptionsValue dateOfCreationOptions = new DateOfCreationOptions
            {
                StartTime = DateTime.Now,
                MinIntervalInMilliseconds = MinIntervalInMilliseconds,
                MaxIntervalInMilliseconds = MaxIntervalInMilliseconds
            };

            CreationOptionsValue creationOptionsOfTheMethod = new CreationOptionsOfTheMethod
            {
                Parameters = Parameters,
                Method = HttpMethods
            };

            CreationOptionsValue creationOptionsProtocol = new CreationOptionsProtocol
            {
                Parameters = Parameters,
                Protocol = Protocol
            };

            CreationOptionsValue creationOptionsFileName = new CreationOptionsFileName
            {
                MinLengthOfFileName = MinLengthOfFileName,
                MaxLengthOfFileName = MaxLengthOfFileName
            };

            CreationOptionsValue creationOptionsFileExtension = new CreationOptionsFileExtension
            {
                Parameters = Parameters,
                FileExtension = FileExtension
            };

            CreationOptionsValue creationOptionsOfTheStatusCode = new CreationOptionsOfTheStatusCode
            {
                Parameters = Parameters,
                StatusCode = StatusCodes
            };

            CreationOptionsValue creationOptionsNumberOfBytes = new CreationOptionsNumberOfBytes
            {
                MinNumberOfBytes = MinNumberOfBytes,
                MaxNumberOfBytes = MaxNumberOfBytes
            };

            IFileGenerator<Ip.Ip> generatorIp = new GeneratorIp();
            IFileGenerator<DateTime> generatorDate = new GeneratorDate();
            IFileGenerator<string> generatorMethod = new GeneratorMethod();
            IFileGenerator<string> generatorProtocol = new GeneratorProtocol();
            IFileGenerator<string> generatorFileName = new GeneratorFileName();
            IFileGenerator<string> generatorFileExtension = new GeneratorFileExtension();
            IFileGenerator<string> generatorStatusCodes = new GeneratorStatusCode();
            IFileGenerator<int> generatorNumberOfBytes = new GeneratorNumberOfBytes();


            for (var i = 0; i < numberLines; i++)
            {
                logRecords.Add(new JournalRecord
                {
                    Date = generatorDate.Generator(dateOfCreationOptions),
                    FileExtension = generatorFileExtension.Generator(creationOptionsFileExtension),
                    FileName = generatorFileName.Generator(creationOptionsFileName),
                    Ip = generatorIp.Generator(creationOptionsIp),
                    Method = generatorMethod.Generator(creationOptionsOfTheMethod),
                    NumberOfBytes = generatorNumberOfBytes.Generator(creationOptionsNumberOfBytes),
                    Protocol = generatorProtocol.Generator(creationOptionsProtocol),
                    StatusCode = generatorStatusCodes.Generator(creationOptionsOfTheStatusCode)
                });
            }
            return logRecords;
        }

    }
}


