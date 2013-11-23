using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
   abstract class CreationOptionsValue
    {
       public readonly Random Random = new Random(DateTime.Now.Millisecond);
    }
}
