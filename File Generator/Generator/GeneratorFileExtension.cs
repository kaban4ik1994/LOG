using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorFileExtension : IFileGenerator<string>
    {

        public string Generator(CreationOptionsValue parameters)
        {
            var parameter = (CreationOptionsFileExtension)parameters;
            return GeneratorRandomValue.GetRandomValue(parameter.FileExtension, parameter.Parameters.AvailableFileExtension);
        }
    }
}
