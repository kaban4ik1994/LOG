using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using File_Analyzer.Analyzer_Param;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    public interface IFileAnaluzer<out T>
    {
        T Analyz(IParametersAnalyzer parameters);

       
    }
}
