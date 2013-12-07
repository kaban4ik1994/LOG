using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorNumberOfBytes:IFileGenerator<int, CreationOptionsNumberOfBytes>
    {
        public int Generator(CreationOptionsNumberOfBytes parameters)
        {
            return parameters.Random.Next(parameters.MinNumberOfBytes, parameters.MaxNumberOfBytes);
        }
    }
}
