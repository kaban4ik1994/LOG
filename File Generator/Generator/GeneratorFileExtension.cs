using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorFileExtension : IFileGenerator<string, CreationOptionsFileExtension>
    {

        public string Generator(CreationOptionsFileExtension parameters)
        {
            return GeneratorRandomValue.GetRandomValue(parameters.FileExtension, parameters.Parameters.AvailableFileExtension);
        }
    }
}
