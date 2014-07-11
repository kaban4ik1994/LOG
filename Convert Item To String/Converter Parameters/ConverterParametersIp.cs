using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert_Item_To_String.Converter;
using Convert_Item_To_String.Parameters_Converter;

namespace Convert_Item_To_String.Converter_Parameters
{
  public  class ConverterParametersIp:IConverterParameters
    {
        public Ip.Ip Ip { get; set; }
    }
}
