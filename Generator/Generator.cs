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
            if (commands.TryGetValue("filepath", out filePath) &&
                   commands.TryGetValue("numberlines", out numberLines))
            {

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
                MaxNumberOfBytes = 100
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











