﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class CreationOptionsOfTheMethod: CreationOptionsValue
    {
        public Settings.Settings Parameters { get; set; }
        public string[]Method { get; set; }
    }
}
