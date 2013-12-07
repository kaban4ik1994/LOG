using System;
using File_Generator;
using Command_Line;
namespace Generator
{
    static class Generator
    {

        static void Main(string[] line)
        {
            string filePath;
            string numberLines;
            var commands = CommandLine.Pars(line);
            if (commands.TryGetValue("filePath", out filePath) &&
                   commands.TryGetValue("numberLines", out numberLines))
            {
                string numberOfUniqueIp;
                commands.TryGetValue("numberOfUniqueIp", out numberOfUniqueIp);   
                var configFileReader = new ConfigFileReader.ConfigFileReader(@"E:\logFiles\Config.yaml");
                var fileGenerator = new FileGenerator
            {
                
                HttpMethods = new[] { "GET", "POST", "DELETE", "PUT" },
                FileExtension = new[] { ".exe", ".txt", ".pdf" },
                Protocol = new[] { "http", "https" },
                StartTime = DateTime.Now,
                StatusCodes = new[] { "301", "302", "303", "403", "404" },
                MinIntervalInMilliseconds = 1,
                Parameters = configFileReader.Settings,
                MaxIntervalInMilliseconds = 1000,
                MinNumberOfBytes = 1,
                NumberOfUniqueIp=Convert.ToInt32(numberOfUniqueIp),
                MaxNumberOfBytes = 100,
                MinNumberOfRepeatedIp = 2,
                MaxNumberOfRepeatedIp = 4,
                MinLengthOfFileName = 4,
                MaxLengthOfFileName = 30

            };
                SaveToFile.SaveToFile.SaveToFileRecords(fileGenerator.CreateLogRecords(Convert.ToInt32(numberLines)), filePath);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}











