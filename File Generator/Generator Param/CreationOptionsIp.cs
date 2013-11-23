using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class CreationOptionsIp:CreationOptionsValue
    {
         public int NumberOfUniqueIp { get; set; }
         public int MinNumberOfRepeatedIp { get; set; }
         public int MaxNumberOfRepeatedIp { get; set; }
         public int Count { get; set; }
    }
}
