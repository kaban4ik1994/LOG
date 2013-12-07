
namespace File_Analyzer.ConverterAnalyzerResult
{
    public interface IConvertorAnalyzerResult<out T, in TL>
    {
        T Convert(TL resultAnalyzer);
    }
}
