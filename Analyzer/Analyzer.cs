using System;
using Command_Line;
using File_Analyzer;
using LOG;
namespace Analyzer
{
    static class Analyzer
    {
        static void Main(string[] line)
        {
            string filePath;
            string numberLines;
            string startLine;
            var commands = CommandLine.Pars(line);
            if (commands.TryGetValue("filepath", out filePath) &&
                commands.TryGetValue("numberlines", out numberLines) &&
                commands.TryGetValue("startline", out startLine))
            {
                var logContent=new LogReader(filePath);
                var fileAnalyzer = new FileAnalyzer(logContent.EventList);
                Console.WriteLine(fileAnalyzer.GetLines(Convert.ToInt32(startLine),Convert.ToInt32(numberLines)));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
