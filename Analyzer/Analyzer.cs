using System;
using System.IO;
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
            string startDate;
            string endDate;
            var commands = CommandLine.Pars(line);
            if (!commands.TryGetValue("filepath", out filePath)) return;
            var logContent = new LogReader(filePath);
            var fileAnalyzer = new FileAnalyzer(logContent.EventList);
            if (commands.TryGetValue("numberlines", out numberLines) &&
                commands.TryGetValue("startline", out startLine))
            {
                //  var grahp = new LibraryCreateGraph(1000, 1000);
                Console.WriteLine(fileAnalyzer.GetLines(Convert.ToInt32(startLine), Convert.ToInt32(numberLines)));

            }
            Console.WriteLine("GET:{0}, POST:{1}, DELETE:{2}, PUT(не описан в файле конфигурации):{3}",
                    fileAnalyzer.GetWeightCoefficientOfMethod("GET"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("POST"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("DELETE"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("PUT"));
            Console.WriteLine("301:{0}, 302:{1}, 303:{2}, 403:{3},404:{4}",
                    fileAnalyzer.GetWeightCoefficientOfMethod("301"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("302"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("303"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("403"),
                    fileAnalyzer.GetWeightCoefficientOfMethod("404"));

            Console.WriteLine("________________________________________________________________________________");
            if (commands.TryGetValue("startdate", out startDate) &&
                !commands.TryGetValue("enddate", out endDate))
            {
                Console.WriteLine(fileAnalyzer.GetLines(Convert.ToDateTime(startDate), fileAnalyzer.GetMaximumDate()));
            }
            if (!commands.TryGetValue("startdate", out startDate) &&
                commands.TryGetValue("enddate", out endDate))
            {
                Console.WriteLine(fileAnalyzer.GetLines(fileAnalyzer.GetMinimumDate(), Convert.ToDateTime(endDate)));
            }
            if (commands.TryGetValue("startdate", out startDate) &&
                commands.TryGetValue("enddate", out endDate))
            {
                Console.WriteLine(fileAnalyzer.GetLines(Convert.ToDateTime(startDate), Convert.ToDateTime(endDate)));
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Unique ip:");
            Console.WriteLine(fileAnalyzer.GetUniqueIp());
        }
    }
}
