using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Analyzer.Result_Analyzer
{
    class ResultAnalyzerByIp: IResultAnalyzer
    {
        public List<Ip.Ip> Result { get; set; }
    }
}
