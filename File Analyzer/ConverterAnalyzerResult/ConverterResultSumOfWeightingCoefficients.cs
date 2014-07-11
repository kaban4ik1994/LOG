using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
