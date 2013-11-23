using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorStatusCode:IFileGenerator<string>
    {
        
        public string Generator(CreationOptionsValue parameters)
        {
            var parameter = (CreationOptionsOfTheStatusCode)parameters;
            return GeneratorRandomValue.GetRandomValue(parameter.StatusCode, parameter.Parameters.AvailableStatusСodes);
        }
    }
}
