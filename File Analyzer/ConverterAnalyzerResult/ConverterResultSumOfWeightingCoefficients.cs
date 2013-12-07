
using System.Globalization;
using System.Text;

namespace File_Analyzer.ConverterAnalyzerResult
{
    class ConverterResultSumOfWeightingCoefficients:IConvertorAnalyzerResult<StringBuilder, int>
    {
        public StringBuilder Convert(int resultAnalyzer)
        {
            return  new StringBuilder(resultAnalyzer.ToString(CultureInfo.InvariantCulture));

        }
    }
}
