using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorProtocol:IFileGenerator<string, CreationOptionsProtocol>
    {

        public string Generator(CreationOptionsProtocol parameters)
        {
            return GeneratorRandomValue.GetRandomValue(parameters.Protocol, parameters.Parameters.AvailableProtocols);
        }
    }
}
