using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Result_Analyzer;

namespace File_Analyzer.ConverterAnalyzerResult
{
    class ConverterResultByWeightingCoefficients : IConvertorAnalyzerResult<StringBuilder>
    {
        public StringBuilder Convert(IResultAnalyzer resultAnalyzer)
        {
            var conversion = (ResultAnalyzerByWeightingCoefficients)resultAnalyzer;
            var resultConvertor =new StringBuilder(conversion.Result.ToString(CultureInfo.InvariantCulture));
            return resultConvertor;
        }
    }
}
