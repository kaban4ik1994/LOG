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
        public StringBuilder Analyz(ResultsAnalyzerFactory typeParameters)
        {

            if (typeParameters!=null)
                return typeParameters.TypeConverterResultAnalyzer.Convert(typeParameters.AnalyzerType.Analyz(typeParameters.TypeParameterAnalyzer));
            return new StringBuilder();
        }
    }
}
