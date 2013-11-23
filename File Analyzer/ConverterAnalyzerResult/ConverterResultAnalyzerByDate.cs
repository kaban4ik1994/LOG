using System.Text;
using Convert_Item_To_String;
using File_Analyzer.Result_Analyzer;

namespace File_Analyzer.ConverterAnalyzerResult
{
    class ConverterResultAnalyzerByDate : IConvertorAnalyzerResult<StringBuilder>
    {
        public StringBuilder Convert(IResultAnalyzer resultAnalyzer)
        {
            var conversion = (ResultAnalyzerByDate)resultAnalyzer;
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
