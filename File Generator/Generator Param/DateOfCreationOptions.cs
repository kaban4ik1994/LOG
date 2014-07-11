using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Generator.Generator_Param
{
    class DateOfCreationOptions:CreationOptionsValue
    {
        public DateTime StartTime { get; set; }
        public int MinIntervalInMilliseconds { get; set; }
        public int MaxIntervalInMilliseconds { get; set; }
    }
}
