using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorMethod:IFileGenerator<string, CreationOptionsOfTheMethod>
    {
       
        public string Generator(CreationOptionsOfTheMethod parameters)
        {
            return GeneratorRandomValue.GetRandomValue(parameters.Method, parameters.Parameters.AvailableMethods);
        }
    }
}
