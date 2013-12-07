using System;
using System.Collections.Generic;
using File_Generator.Generator;
using File_Generator.Generator_Param;
using Journal_Record;
using Ninject;

namespace File_Generator
{
    public class FileGenerator
    {

        public int MinNumberOfRepeatedIp { private get; set; }

        public int MaxNumberOfRepeatedIp { private get; set; }

        public int NumberOfUniqueIp { private get; set; }

        public string[] Protocol { private get; set; }

        public string[] HttpMethods { private get; set; }

        public string[] StatusCodes { private get; set; }

        public string[] FileExtension { private get; set; }

        public DateTime StartTime { private get; set; }

        public int MinIntervalInMilliseconds { private get; set; }

        public int MaxIntervalInMilliseconds { private get; set; }

        public int MinNumberOfBytes { private get; set; }

        public int MaxNumberOfBytes { private get; set; }

        public Settings.Settings Parameters { private get; set; }

        public int MinLengthOfFileName { private get; set; }

        public int MaxLengthOfFileName { private get; set; }

        private IKernel _appKernel;

        public List<JournalRecord> CreateLogRecords(int numberLines)
        {
            var logRecords = new List<JournalRecord>();
            _appKernel = new StandardKernel(new GeneratorNinjectModule());
            var creationOptionsIp = new CreationOptionsIp
            {
                NumberOfUniqueIp = NumberOfUniqueIp,
                MinNumberOfRepeatedIp = MinNumberOfRepeatedIp,
                MaxNumberOfRepeatedIp = MaxNumberOfRepeatedIp,
                Count = numberLines
            };

            var dateOfCreationOptions = new DateOfCreationOptions
            {
                StartTime = DateTime.Now,
                MinIntervalInMilliseconds = MinIntervalInMilliseconds,
                MaxIntervalInMilliseconds = MaxIntervalInMilliseconds
            };

            var creationOptionsOfTheMethod = new CreationOptionsOfTheMethod
            {
                Parameters = Parameters,
                Method = HttpMethods
            };

            var creationOptionsProtocol = new CreationOptionsProtocol
            {
                Parameters = Parameters,
                Protocol = Protocol
            };

            var creationOptionsFileName = new CreationOptionsFileName
            {
                MinLengthOfFileName = MinLengthOfFileName,
                MaxLengthOfFileName = MaxLengthOfFileName
            };

            var creationOptionsFileExtension = new CreationOptionsFileExtension
            {
                Parameters = Parameters,
                FileExtension = FileExtension
            };

            var creationOptionsOfTheStatusCode = new CreationOptionsOfTheStatusCode
            {
                Parameters = Parameters,
                StatusCode = StatusCodes
            };

            var creationOptionsNumberOfBytes = new CreationOptionsNumberOfBytes
            {
                MinNumberOfBytes = MinNumberOfBytes,
                MaxNumberOfBytes = MaxNumberOfBytes
            };

            var generatorIp = _appKernel.Get<GeneratorIp>();
            var generatorDate = _appKernel.Get<GeneratorDate>();
            var generatorMethod = _appKernel.Get<GeneratorMethod>();
            var generatorProtocol = _appKernel.Get<GeneratorProtocol>();
            var generatorFileName = _appKernel.Get<GeneratorFileName>();
            var generatorFileExtension = _appKernel.Get<GeneratorFileExtension>();
            var generatorStatusCodes = _appKernel.Get<GeneratorStatusCode>();
            var generatorNumberOfBytes = _appKernel.Get<GeneratorNumberOfBytes>();


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


