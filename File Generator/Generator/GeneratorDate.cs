using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorDate : IFileGenerator<DateTime>
    {
        public DateTime Generator(CreationOptionsValue parameters)
        {
            var parameter = (DateOfCreationOptions)parameters;
            var date = parameter.StartTime;
            parameter.StartTime = parameter.StartTime.AddMilliseconds(parameter.Random.Next(parameter.MinIntervalInMilliseconds, parameter.MaxIntervalInMilliseconds));
            return date;
        }
    }
}
