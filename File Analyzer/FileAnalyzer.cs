using System;
using System.Collections.Generic;
using System.Text;
using File_Analyzer.Analyzer;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.ConverterAnalyzerResult;
using File_Analyzer.Result_Analyzer;
using Journal_Record;

namespace File_Analyzer
{
    public class FileAnalyzer
    {
        public StringBuilder Analyz(IParametersAnalyzer parametersAnalyzer, IFileAnaluzer<dynamic> fileAnaluzer,IConvertorAnalyzerResult<StringBuilder> typeConverter)
        {
           
            if (parametersAnalyzer != null && fileAnaluzer != null)
                return typeConverter.Convert(fileAnaluzer.Analyz(parametersAnalyzer));
            return new StringBuilder();
        }
    }
}
