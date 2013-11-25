using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using File_Analyzer.Result_Analyzer;

namespace File_Analyzer
{
    public class ResultsAnalyzerFactory
    {
        public IParametersAnalyzer TypeParameterAnalyzer { get; set; }
        public IFileAnaluzer<IResultAnalyzer> AnalyzerType { get; set; }
        public IConvertorAnalyzerResult<StringBuilder> TypeConverterResultAnalyzer { get; set; }

    }
}
