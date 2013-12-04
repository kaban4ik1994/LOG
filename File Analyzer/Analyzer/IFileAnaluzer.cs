

namespace File_Analyzer.Analyzer
{
    public interface IFileAnaluzer<out T, in TL>
    {
        T Analyz(TL parameters);  
    }
}
