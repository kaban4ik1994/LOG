using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert_Item_To_String;
using File_Analyzer.Result_Analyzer;

namespace File_Analyzer.ConverterAnalyzerResult
{
    class ConverterResultLinesAnalyzer : IConvertorAnalyzerResult<StringBuilder>
    {
        public StringBuilder Convert(IResultAnalyzer resultAnalyzer)
        {
            var conversion = (ResultLinesAnalyzer)resultAnalyzer;
            var resultConvertor = new StringBuilder();
            var converter = new ConvertItemToString();
            foreach (var result in conversion.Result)
            {
                resultConvertor.AppendLine(converter.ConvertToString(result));
            }
            return resultConvertor;
        }
    }
}
