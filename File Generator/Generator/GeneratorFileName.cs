using System;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorFileName:IFileGenerator<string, CreationOptionsFileName>
    {
        public string Generator(CreationOptionsFileName parameters)
        {
            var result = string.Empty;
            for (var i = parameters.MinLengthOfFileName; i < parameters.MaxLengthOfFileName; i++)
            {
                result += Convert.ToChar(parameters.Random.Next(97, 122));
            }
            return result;
        }
    }
}
