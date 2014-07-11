using File_Analyzer.Result_Analyzer;

namespace File_Analyzer.ConverterAnalyzerResult
{
    public interface IConvertorAnalyzerResult<out T, in TL>
    {
        T Convert(TL resultAnalyzer);
    }
}
