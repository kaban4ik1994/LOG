using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace File_Analyzer.Analyzer_Param
{
    class ParametersOfAnalyzerLine : IParametersAnalyzer
    {

        public int StartLine { get; set; }

        public int NumberLines { get; set; }


    }
}
