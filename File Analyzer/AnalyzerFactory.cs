using System;
using System.Collections.Generic;
using System.IO.Pipes;
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

        public static ResultsAnalyzerFactory GetResultsAnalyzerFactory()
        {
            string typeAnalyzer;
            CommandLineParameters.TryGetValue("report", out typeAnalyzer);
            var resultsAnalyzerFactory = new ResultsAnalyzerFactory();
            if (typeAnalyzer == "LinesAnalyzer")
            {
                string numberLines;
                string startLine;
                CommandLineParameters.TryGetValue("numberLine", out numberLines);
                CommandLineParameters.TryGetValue("startLine", out startLine);

                resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersOfAnalyzerLine
                {
                    NumberLines = Convert.ToInt32(numberLines),
                    StartLine = Convert.ToInt32(startLine)
                };
                resultsAnalyzerFactory.AnalyzerType = new LinesAnalyzer
                {
                    RecordList = RecordList
                };
                resultsAnalyzerFactory.TypeConverterResultAnalyzer = new ConverterResultLinesAnalyzer();
                return resultsAnalyzerFactory;
            }

            if (typeAnalyzer == "AnalyzerByWeightCoefficients")
            {
                string value;
                CommandLineParameters.TryGetValue("Value", out value);
                resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersAnalyzerByWeightingCoefficients
                {
                    ValueName = value
                };
                resultsAnalyzerFactory.AnalyzerType = new AnalyzerByWeightingCoefficients
                {
                    RecordList = RecordList
                };
                resultsAnalyzerFactory.TypeConverterResultAnalyzer = new ConverterResultByWeightingCoefficients();
                return resultsAnalyzerFactory;
            }

            if (typeAnalyzer == "AnalyzerByIp")
            {
                resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersAnalyzerByIp();
                resultsAnalyzerFactory.AnalyzerType = new AnalyzerByIp
                {
                    RecordList = RecordList
                };
                resultsAnalyzerFactory.TypeConverterResultAnalyzer = new ConverterResultByIp();
                return resultsAnalyzerFactory;
            }
            if (typeAnalyzer == "AnalyzerByDate")
            {
                string startTime;
                string endTime;
                CommandLineParameters.TryGetValue("startDate", out startTime);
                CommandLineParameters.TryGetValue("endDate", out endTime);
                resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersAnalyzerByDate
                {
                    EndDate = Convert.ToDateTime(endTime),
                    StartDate = Convert.ToDateTime(startTime)
                };
                resultsAnalyzerFactory.AnalyzerType = new AnalyzerByDate
                {
                    RecordList = RecordList
                };
                resultsAnalyzerFactory.TypeConverterResultAnalyzer = new ConverterResultAnalyzerByDate();
                return resultsAnalyzerFactory;
            }
            return null;


        }

    }
}