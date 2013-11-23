using System.Collections.Generic;
using System.Linq;
using System.Text;
using Convert_Item_To_String;
using File_Analyzer.Analyzer_Param;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class LinesAnalyzer : IFileAnaluzer<StringBuilder>
    {

        public List<JournalRecord> RecordList { get; set; }
        
        public StringBuilder Analyzer(ParametersAnalyzer parameters)
        {

            var parameter = (ParametersOfAnalyzerLine) parameters;
            var result = new StringBuilder();
            var converter = new ConvertItemToString();
            if (!RecordList.Any()) return result;
            for (var i =parameter.StartLine; i < parameter.StartLine + parameter.NumberLines; i++)
            {
                result.AppendLine(converter.ConvertToString(RecordList.ElementAt(i)));
            }
            return result;
        }

        
    }
}
