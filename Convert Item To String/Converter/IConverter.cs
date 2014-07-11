using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert_Item_To_String.Parameters_Converter;

namespace Convert_Item_To_String.Converter
{
    interface IConverter<out T>
    {
        T Convert(IConverterParameters converterParameters);
    }
}
