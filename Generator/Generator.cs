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
                var fileGenerator = new FileGenerator
                {
                    HttpMethods = new[] { "GET", "POST", "DELETE" },
                    FileExtension = new[] { ".exe", ".txt", ".pdf" },
                    Protocol = new[] { "http", "https" },
                    StartTime = DateTime.Now,
                    StatusCodes = new[] { 301, 302, 303, 403, 404 },
                    MinIntervalInMilliseconds = 1,
                    MaxIntervalInMilliseconds = 1000
                };

                fileGenerator.CreateFile(filePath, Convert.ToInt32(numberLines));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
