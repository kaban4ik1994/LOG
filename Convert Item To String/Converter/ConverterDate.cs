using Convert_Item_To_String.Converter_Parameters;
using Convert_Item_To_String.Parameters_Converter;

namespace Convert_Item_To_String.Converter
{
  public  class ConverterDate : IConverter<string>
    {
        public string Convert(IConverterParameters converterParameters)
        {
            var converterParametersDate = (ConverterParametersDate)converterParameters;
            
            var result = string.Format(
                "{0}/{1}/{2}:{3}:{4}:{5}", converterParametersDate.DateTime.Day, converterParametersDate.DateTime.Month,
                converterParametersDate.DateTime.Year, converterParametersDate.DateTime.Hour,
                converterParametersDate.DateTime.Minute, converterParametersDate.DateTime.Second);
            return result;

        }
    }
}
