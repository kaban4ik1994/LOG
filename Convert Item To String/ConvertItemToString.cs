using Convert_Item_To_String.Converter;
using Convert_Item_To_String.Converter_Parameters;
using Journal_Record;
namespace Convert_Item_To_String
{
    public class ConvertItemToString
    {
        public string ConvertToString(JournalRecord item)
        {
            IConverter<string> converterIp=new ConverterIp();
            IConverter<string> converterDate=new ConverterDate();
            var result = string.Format(
                    "{0} - - [{1}] {2} {3}://{4}{5} {6} {7}",
                    converterIp.Convert(new ConverterParametersIp{Ip=item.Ip}), converterDate.Convert(new ConverterParametersDate{DateTime = item.Date}),item.Method,
                    item.Protocol, item.FileName, item.FileExtension,item.StatusCode, item.NumberOfBytes);
            return result;
        }
    }
}
