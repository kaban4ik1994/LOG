using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convert_Item_To_String.Converter_Parameters;
using Convert_Item_To_String.Parameters_Converter;

namespace Convert_Item_To_String.Converter
{
    public class ConverterIp : IConverter<string>
    {
        public string Convert(IConverterParameters converterParameters)
        {
            var converterParametersIp = (ConverterParametersIp) converterParameters;
            var result = string.Format(
                "{0}.{1}.{2}.{3}", converterParametersIp.Ip.IpByte1, converterParametersIp.Ip.IpByte2,
                converterParametersIp.Ip.IpByte3, converterParametersIp.Ip.IpByte4);
            return result;

        }
    }
}
