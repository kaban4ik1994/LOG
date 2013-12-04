using System;
using System.IO;
using System.Linq;
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
            var commands = CommandLine.Pars(line);
            if (!commands.TryGetValue("filepath", out filePath)) return;
            var logContent = new LogReader(filePath);
            var fileAnalyzer = new FileAnalyzer
            {
                Parameters = commands,
                RecordList = logContent.EventList.ToList()
            };

            //  var grahp = new LibraryCreateGraph(1000, 1000);
                Console.WriteLine(fileAnalyzer.GetResultsAnalyzer());
            }
          
        }
    }

