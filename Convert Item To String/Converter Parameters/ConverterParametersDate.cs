using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert_Item_To_String.Parameters_Converter;

namespace Convert_Item_To_String.Converter_Parameters
{
  public  class ConverterParametersDate:IConverterParameters
    {
        public DateTime DateTime { get; set; }
    }
}
