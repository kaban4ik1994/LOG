using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorStatusCode:IFileGenerator<string, CreationOptionsOfTheStatusCode>
    {

        public string Generator(CreationOptionsOfTheStatusCode parameters)
        {
            return GeneratorRandomValue.GetRandomValue(parameters.StatusCode, parameters.Parameters.AvailableStatusСodes);
        }
    }
}
