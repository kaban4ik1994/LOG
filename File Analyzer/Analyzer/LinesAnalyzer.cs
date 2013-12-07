using System.Collections.Generic;
using System.Linq;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class LinesAnalyzer : IFileAnaluzer<ResultLinesAnalyzer,ParametersOfAnalyzerLine>
    {

        public List<JournalRecord> RecordList { private get; set; }

        public ResultLinesAnalyzer Analyz(ParametersOfAnalyzerLine parameters)
        {

            var result = new ResultLinesAnalyzer
            {
                Result = new List<JournalRecord>()
            };
            if (!RecordList.Any()) return result;
            if (parameters.StartLine > RecordList.Count) parameters.StartLine = 0;
            if (parameters.StartLine + parameters.NumberLines > RecordList.Count) parameters.NumberLines = 0;
            for (var i = parameters.StartLine; i < parameters.StartLine + parameters.NumberLines; i++)
            {
                result.Result.Add(RecordList.ElementAt(i));
            }
            return result;
        }
    }
}
