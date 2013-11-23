using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class CreationOptionsFileName:CreationOptionsValue
    {
        public int MinLengthOfFileName { get; set; }
        public int MaxLengthOfFileName { get; set; }

    }
}
