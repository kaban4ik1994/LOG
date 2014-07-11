using System;
using System.Collections.Generic;
using System.Text;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using Journal_Record;
using Ninject;

namespace File_Analyzer
{
    public class FileAnalyzer
    {

        public  Dictionary<string, string> Parameters { get; set; }
        public  List<JournalRecord> RecordList { get; set; }

        private IKernel _appKernel;

        public  StringBuilder GetResultsAnalyzer()
        {
            if (Parameters != null && RecordList != null)
            {
                string typeAnalyzer;
                Parameters.TryGetValue("report", out typeAnalyzer);

                _appKernel = new StandardKernel(new AnalyzerNinjectModule());
   
                    string startTime;
                    string endTime;
                    Parameters.TryGetValue("startDate", out startTime);
                    Parameters.TryGetValue("endDate", out endTime);
                    DateTime tempDate;
                    var parameters = new ParametersAnalyzerByDate
                    {
                        EndDate = DateTime.TryParse(endTime, out tempDate) ? tempDate : new DateTime(),
                        StartDate = DateTime.TryParse(startTime, out tempDate) ? tempDate : new DateTime()
                    };
                    var selectionbByDate = _appKernel.Get<AnalyzerByDate>();
                    selectionbByDate.RecordList = RecordList;
                    RecordList = selectionbByDate.Analyz(parameters).Result;

                if (typeAnalyzer == "AnalyzerByDate")
                {
                    var typeConverter = _appKernel.Get<ConverterResultAnalyzerByDate>();
                    return typeConverter.Convert(selectionbByDate.Analyz(parameters));
                }
 

                if (typeAnalyzer == "LinesAnalyzer")
                {
                    string numberLines;
                    string startLine;
                    int tempValue;
                    Parameters.TryGetValue("numberLine", out numberLines);
                    Parameters.TryGetValue("startLine", out startLine);
                    var typeParameterAnalyzer = new ParametersOfAnalyzerLine
                    {
                        NumberLines = int.TryParse(numberLines, out tempValue) ? tempValue : 0,
                        StartLine = int.TryParse(startLine, out tempValue) ? tempValue : 0
                    };
                    var analyzerType = _appKernel.Get<LinesAnalyzer>();
                    analyzerType.RecordList = RecordList;
                    var typeConverter = _appKernel.Get<ConverterResultLinesAnalyzer>();

                    return typeConverter.Convert(analyzerType.Analyz(typeParameterAnalyzer));
                }

                if (typeAnalyzer == "AnalyzerByWeightCoefficients")
                {
                    string value;
                    Parameters.TryGetValue("Value", out value);
                    var typeParameterAnalyzer = new ParametersAnalyzerByWeightingCoefficients
                    {
                        ValueName = value
                    };

                    var analyzerType = _appKernel.Get<AnalyzerByWeightingCoefficients>();
                    analyzerType.RecordList = RecordList;

                    var typeConverter = _appKernel.Get<ConverterResultByWeightingCoefficients>();

                    return typeConverter.Convert(analyzerType.Analyz(typeParameterAnalyzer));
                }

                if (typeAnalyzer == "AnalyzerByIp")
                {
                    var typeParameterAnalyzer = new ParametersAnalyzerByIp();
                    var analyzerType = _appKernel.Get<AnalyzerByIp>();
                    analyzerType.RecordList = RecordList;
                    var typeConverter = _appKernel.Get<ConverterResultByIp>();

                    return typeConverter.Convert(analyzerType.Analyz(typeParameterAnalyzer));
                }

                if (typeAnalyzer == "SumOfWeightingCoefficients")
                {
                    var typeParameterAnalyzer = new ParametersSumOfWeightingCoefficients();
                    var analyzerType = _appKernel.Get<SumOfWeightingCoefficients>();
                    analyzerType.RecordList = RecordList;
                    var typeConverter = _appKernel.Get<ConverterResultSumOfWeightingCoefficients>();
                    return typeConverter.Convert(analyzerType.Analyz(typeParameterAnalyzer));

                }
               
            }
            return null;


        }
    }
}
