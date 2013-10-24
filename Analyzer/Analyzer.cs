using System;
using System.Collections.Generic;
using System.Drawing;
using Command_Line;
using File_Analyzer;
using LOG;
using Library_Create_Graph;
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
                var logContent = new LogReader(filePath);
                var fileAnalyzer = new FileAnalyzer(logContent.EventList);
              //  var grahp = new LibraryCreateGraph(1000, 1000);
                Console.WriteLine(fileAnalyzer.GetLines(Convert.ToInt32(startLine), Convert.ToInt32(numberLines)));
                Console.WriteLine("GET:{0}, POST:{1}, DELETE:{2}, PUT(не описан в файле конфигурации:{3}",
                    fileAnalyzer.GetWeightCoefficientOfMethod("GET"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("POST"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("DELETE"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("PUT"));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
