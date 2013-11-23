using File_Analyzer.Analyzer_Param;

namespace File_Analyzer.Analyzer
{
    interface IFileAnaluzer<out T>
    {
        T Analyzer(ParametersAnalyzer parameters);
    }
}
