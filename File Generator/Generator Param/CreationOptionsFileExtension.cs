using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class CreationOptionsFileExtension:CreationOptionsValue
    {
        public Settings.Settings Parameters { get; set; }
        public string[] FileExtension { get; set;}
    }
}
