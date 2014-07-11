using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class CreationOptionsNumberOfBytes: CreationOptionsValue
    {
        public int MinNumberOfBytes { get; set; }
        public int MaxNumberOfBytes { get; set; }
    }
}
