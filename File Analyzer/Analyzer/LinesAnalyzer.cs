using System.Collections.Generic;
using System.Linq;
using System.Text;
using Convert_Item_To_String;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class LinesAnalyzer : IFileAnaluzer<ResultLinesAnalyzer>
    {

        public List<JournalRecord> RecordList { get; set; }

        public ResultLinesAnalyzer Analyz(IParametersAnalyzer parameters)
        {

            var parameter = (ParametersOfAnalyzerLine)parameters;
            var result = new ResultLinesAnalyzer
            {
                Result = new List<JournalRecord>()
            };
            var converter = new ConvertItemToString();
            if (!RecordList.Any()) return result;
            for (var i = parameter.StartLine; i < parameter.StartLine + parameter.NumberLines; i++)
            {
                result.Result.Add(RecordList.ElementAt(i));
            }
            return result;
        }


    }
}
