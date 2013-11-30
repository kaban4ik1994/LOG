using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using File_Analyzer.Result_Analyzer;
using Journal_Record;
using Ninject;
using Ninject.Parameters;

namespace File_Analyzer
{
    public static class AnalyzerFactory
    {
        public static Dictionary<string, string> CommandLineParameters { get; set; }
        public static List<JournalRecord> RecordList { get; set; }

        public static IKernel AppKernel;

        public static ResultsAnalyzerFactory GetResultsAnalyzerFactory()
        {
            if (CommandLineParameters != null && RecordList != null)
            {
                string typeAnalyzer;
                CommandLineParameters.TryGetValue("report", out typeAnalyzer);

                var resultsAnalyzerFactory = new ResultsAnalyzerFactory();
                AppKernel = new StandardKernel(new AnalyzerNinjectModule { Parameters = typeAnalyzer });
                if (typeAnalyzer == "LinesAnalyzer")
                {
                    string numberLines;
                    string startLine;
                    var tempValue = 0;
                    CommandLineParameters.TryGetValue("numberLine", out numberLines);
                    CommandLineParameters.TryGetValue("startLine", out startLine);
                    resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersOfAnalyzerLine
                    {
                        NumberLines = int.TryParse(numberLines, out tempValue) ? tempValue : 0,
                        StartLine = int.TryParse(startLine, out tempValue) ? tempValue : 0
                    };

                    var analyzerType = AppKernel.Get<LinesAnalyzer>();
                    analyzerType.RecordList = RecordList;
                    resultsAnalyzerFactory.AnalyzerType = analyzerType;
                    var typeConverterResultAnalyzer = AppKernel.Get<ConverterResultLinesAnalyzer>();
                    resultsAnalyzerFactory.TypeConverterResultAnalyzer = typeConverterResultAnalyzer;
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

                    var analyzerType = AppKernel.Get<AnalyzerByWeightingCoefficients>();
                    analyzerType.RecordList = RecordList;
                    resultsAnalyzerFactory.AnalyzerType = analyzerType;
                    var typeConverterResultAnalyzer = AppKernel.Get<ConverterResultByWeightingCoefficients>();
                    resultsAnalyzerFactory.TypeConverterResultAnalyzer = typeConverterResultAnalyzer;
                    return resultsAnalyzerFactory;
                }

                if (typeAnalyzer == "AnalyzerByIp")
                {
                    resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersAnalyzerByIp();
                    var analyzerType = AppKernel.Get<AnalyzerByIp>();
                    analyzerType.RecordList = RecordList;
                    resultsAnalyzerFactory.AnalyzerType = analyzerType;

                    resultsAnalyzerFactory.TypeConverterResultAnalyzer = AppKernel.Get<ConverterResultByIp>();
                    return resultsAnalyzerFactory;
                }
                if (typeAnalyzer == "AnalyzerByDate")
                {
                    string startTime;
                    string endTime;
                    CommandLineParameters.TryGetValue("startDate", out startTime);
                    CommandLineParameters.TryGetValue("endDate", out endTime);
                    DateTime tempValue;
                    resultsAnalyzerFactory.TypeParameterAnalyzer = new ParametersAnalyzerByDate
                    {
                        EndDate = DateTime.TryParse(endTime, out tempValue) ? tempValue : new DateTime(),
                        StartDate = DateTime.TryParse(startTime, out tempValue) ? tempValue : new DateTime()
                    };
                    var analyzerType = AppKernel.Get<AnalyzerByDate>();
                    analyzerType.RecordList = RecordList;
                    resultsAnalyzerFactory.AnalyzerType = analyzerType;
                    resultsAnalyzerFactory.TypeConverterResultAnalyzer = AppKernel.Get<ConverterResultAnalyzerByDate>();
                    return resultsAnalyzerFactory;
                }
            }
            return null;


        }

    }
}