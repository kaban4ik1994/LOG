using System;
using System.Collections.Generic;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class AnalyzerByWeightingCoefficients : IFileAnaluzer<ResultAnalyzerByWeightingCoefficients>
    {
        public List<JournalRecord> RecordList { get; set; }

        public ResultAnalyzerByWeightingCoefficients Analyz(IParametersAnalyzer parameters)
        {
            var parameter = (ParametersAnalyzerByWeightingCoefficients)parameters;
            double count = 0;
            foreach (var value in RecordList)
            {
                if (value.Method == parameter.ValueName) count++;
                if (value.FileExtension == parameter.ValueName) count++;
                if (value.Protocol == parameter.ValueName) count++;
                if (value.StatusCode == parameter.ValueName) count++;
            }

            return new ResultAnalyzerByWeightingCoefficients {Result = count/RecordList.Count};
        }


    }
}
