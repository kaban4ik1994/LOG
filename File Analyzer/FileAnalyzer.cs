using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using Journal_Record;
using Convert_Item_To_String;
using Ip = Ip.Ip;

namespace File_Analyzer
{
    public class FileAnalyzer
    {
        public List<JournalRecord> RecordList { get; set; }

        public StringBuilder GetLines(int startingLine, int countLine)
        {
            IFileAnaluzer<StringBuilder> analyzerInterface = new LinesAnalyzer
            {
                RecordList = RecordList
            };
            ParametersAnalyzer parameters=new ParametersOfAnalyzerLine
            {
                NumberLines = countLine,
                StartLine = startingLine
            };
            return analyzerInterface.Analyzer(parameters);
        }

        public double GetWeightCoefficientOfMethod(string valueName)
        {
            IFileAnaluzer<double> analyzerInterface = new AnalyzerByWeightingCoefficients 
            {
                RecordList = RecordList
            };
            ParametersAnalyzer parameters = new ParametersAnalyzerByWeightingCoefficients
            {
               ValueName = valueName
            };
            return analyzerInterface.Analyzer(parameters); 
        }

        public StringBuilder GetLines(DateTime startDate, DateTime endDate)
        {
            IFileAnaluzer<StringBuilder> analyzerInterface = new AnalyzerByDate
            {
                RecordList = RecordList
            };
         ParametersAnalyzer parameters=new ParametersAnalyzerByDate
         {
             StartDate = startDate,
             EndDate = endDate
         };
          return analyzerInterface.Analyzer(parameters);
        }

        public StringBuilder GetUniqueIp()
        {
            IFileAnaluzer<StringBuilder> analyzerInterface = new AnalyzerByIp
            {
                RecordList = RecordList
            };
           ParametersAnalyzer parameters=new ParametersAnalyzerByIp();
           return analyzerInterface.Analyzer(parameters);
        }
    }
}
