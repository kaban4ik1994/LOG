using System.Collections.Generic;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class AnalyzerByWeightingCoefficients : IFileAnaluzer<ResultAnalyzerByWeightingCoefficients,ParametersAnalyzerByWeightingCoefficients>
    {
        public List<JournalRecord> RecordList { private get; set; }

        public ResultAnalyzerByWeightingCoefficients Analyz(ParametersAnalyzerByWeightingCoefficients parameters)
        {
            double count = 0;
            foreach (var value in RecordList)
            {
                if (value.Method == parameters.ValueName) count++;
                if (value.FileExtension == parameters.ValueName) count++;
                if (value.Protocol == parameters.ValueName) count++;
                if (value.StatusCode == parameters.ValueName) count++;
            }

            return new ResultAnalyzerByWeightingCoefficients {Result = count/RecordList.Count};
        }


    }
}
