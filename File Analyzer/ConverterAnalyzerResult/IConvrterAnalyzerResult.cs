using File_Analyzer.Result_Analyzer;

namespace File_Analyzer.ConverterAnalyzerResult
{
    public interface IConvertorAnalyzerResult<out T>
    {
        T Convert(IResultAnalyzer resultAnalyzer);
    }
}
