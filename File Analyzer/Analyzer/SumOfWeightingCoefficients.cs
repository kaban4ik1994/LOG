using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Analyzer.Analyzer_Param;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class SumOfWeightingCoefficients:IFileAnaluzer<int,ParametersSumOfWeightingCoefficients>
    {
        public List<JournalRecord> RecordList { private get; set; }

        public int Analyz(ParametersSumOfWeightingCoefficients parameters)
        {
            return RecordList.Sum(value => value.NumberOfBytes);
        }
    }
}
