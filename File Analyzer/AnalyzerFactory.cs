using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer
{
    public static class AnalyzerFactory
    {
        public static Dictionary<string, string> CommandLineParameters { get; set; }
        public static List<JournalRecord> RecordList { get; set; }

        public static IParametersAnalyzer GetParameterAnalyzer()
        {
            string typeAnalyzer;
            CommandLineParameters.TryGetValue("report", out typeAnalyzer);
            IParametersAnalyzer parametersAnalyzer;
            if (typeAnalyzer == "LinesAnalyzer")
            {
                string numberLines;
                string startLine;
                CommandLineParameters.TryGetValue("numberLine", out numberLines);
                CommandLineParameters.TryGetValue("startLine", out startLine);

                parametersAnalyzer = new ParametersOfAnalyzerLine
                {
                    NumberLines = Convert.ToInt32(numberLines),
                    StartLine = Convert.ToInt32(startLine)
                };
                return parametersAnalyzer;
            }

            if (typeAnalyzer == "AnalyzerByWeightCoefficients")
            {
                string value;
                CommandLineParameters.TryGetValue("Value", out value);
                parametersAnalyzer = new ParametersAnalyzerByWeightingCoefficients
                {
                    ValueName = value
                };
                return parametersAnalyzer;
            }

            if (typeAnalyzer == "AnalyzerByIp")
            {
                parametersAnalyzer = new ParametersAnalyzerByIp();
                return parametersAnalyzer;
            }
            if (typeAnalyzer == "AnalyzerByDate")
            {
                string startTime;
                string endTime;
                CommandLineParameters.TryGetValue("startDate", out startTime);
                CommandLineParameters.TryGetValue("endDate", out endTime);
                parametersAnalyzer = new ParametersAnalyzerByDate
                {
                    EndDate = Convert.ToDateTime(endTime),
                    StartDate = Convert.ToDateTime(startTime)
                };
                return parametersAnalyzer;
            }
            return null;
        }

        public static IFileAnaluzer<IResultAnalyzer> GetAnalyzer()
        {
            string typeAnalyzer;
            CommandLineParameters.TryGetValue("report", out typeAnalyzer);

            if (typeAnalyzer == "LinesAnalyzer")
            {
                IFileAnaluzer<ResultLinesAnalyzer> analyzerInterface = new LinesAnalyzer
                 {
                     RecordList = RecordList
                 };
                return analyzerInterface;
            }

            if (typeAnalyzer == "AnalyzerByWeightCoefficients")
            {
                IFileAnaluzer<ResultAnalyzerByWeightingCoefficients> analyzerInterface = new AnalyzerByWeightingCoefficients
                {
                    RecordList = RecordList
                };
                return analyzerInterface;
            }

            if (typeAnalyzer == "AnalyzerByIp")
            {
                IFileAnaluzer<ResultAnalyzerByIp> analyzerInterface = new AnalyzerByIp
                {
                    RecordList = RecordList
                };
                return analyzerInterface;
            }

            if (typeAnalyzer == "AnalyzerByDate")
            {
                IFileAnaluzer<ResultAnalyzerByDate> analyzerInterface = new AnalyzerByDate
                {
                    RecordList = RecordList
                };
                return analyzerInterface;
            }
            return null;
        }

        public static IConvertorAnalyzerResult<StringBuilder> GetConvertAnalyzer()
        {
            string typeAnalyzer;
            CommandLineParameters.TryGetValue("report", out typeAnalyzer);

            if (typeAnalyzer == "LinesAnalyzer")
            {  
                var analyzerInterface=new ConverterResultLinesAnalyzer();
                return analyzerInterface;
            }

            if (typeAnalyzer == "AnalyzerByWeightCoefficients")
            {
                var analyzerInterface = new ConverterResultByWeightingCoefficients();
                return analyzerInterface;
            }

            if (typeAnalyzer == "AnalyzerByIp")
            {
                var analyzerInterface = new ConverterResultByIp();
                return analyzerInterface;
            }

            if (typeAnalyzer == "AnalyzerByDate")
            {
                var analyzerInterface = new ConverterResultAnalyzerByDate();
                return analyzerInterface;
            }
            return null;
        }
    }
}