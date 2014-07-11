using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorFileName:IFileGenerator<string>
    {
        public string Generator(CreationOptionsValue parameters)
        {
            var parameter = (CreationOptionsFileName) parameters;
            var result = string.Empty;
            for (var i = parameter.MinLengthOfFileName; i < parameter.MaxLengthOfFileName; i++)
            {
                result += Convert.ToChar(parameter.Random.Next(97, 122));
            }
            return result;
        }
    }
}
