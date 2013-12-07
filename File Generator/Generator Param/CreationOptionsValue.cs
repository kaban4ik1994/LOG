using System;

namespace File_Generator.Generator_Param
{
   abstract class CreationOptionsValue
    {
       public readonly Random Random = new Random(DateTime.Now.Millisecond);
    }
}
