
using Convert_Item_To_String.Parameters_Converter;

namespace Convert_Item_To_String.Converter
{
    interface IConverter<out T>
    {
        T Convert(IConverterParameters converterParameters);
    }
}
