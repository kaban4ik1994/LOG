using System;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorDate : IFileGenerator<DateTime, DateOfCreationOptions>
    {
        public DateTime Generator(DateOfCreationOptions parameters)
        {
            var date = parameters.StartTime;
            parameters.StartTime = parameters.StartTime.AddMilliseconds(parameters.Random.Next(parameters.MinIntervalInMilliseconds, parameters.MaxIntervalInMilliseconds));
            return date;
        }
    }
}
