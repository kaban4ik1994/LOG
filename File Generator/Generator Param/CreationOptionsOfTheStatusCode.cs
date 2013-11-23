using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class CreationOptionsOfTheStatusCode: CreationOptionsValue
    {
        public string[] StatusCode { get; set; }
        public Settings.Settings Parameters { get; set; }
    }
}
