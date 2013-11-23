using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Analyzer.Analyzer_Param
{
    class ParametersOfAnalyzerLine:ParametersAnalyzer
    {
        public int StartLine { get; set; }
        public int NumberLines { get; set; }
    }
}
