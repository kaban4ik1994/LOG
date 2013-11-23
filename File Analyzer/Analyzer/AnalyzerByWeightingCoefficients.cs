using System.Collections.Generic;
using File_Analyzer.Analyzer_Param;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class AnalyzerByWeightingCoefficients : IFileAnaluzer<double>
    {
        public List<JournalRecord> RecordList { get; set; }

        public double Analyzer(ParametersAnalyzer parameters)
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
            return count / RecordList.Count;
        }


    }
}
