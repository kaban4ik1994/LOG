using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorNumberOfBytes:IFileGenerator<int>
    {
        public int Generator(CreationOptionsValue parameters)
        {
            var parameter = (CreationOptionsNumberOfBytes) parameters;
            return parameter.Random.Next(parameter.MinNumberOfBytes, parameter.MaxNumberOfBytes);
        }
    }
}
