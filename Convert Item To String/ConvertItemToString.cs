using Journal_Record;
namespace Convert_Item_To_String
{
    public class ConvertItemToString
    {
        public string ConvertToString(JournalRecord item)
        {
            var result = string.Format(
                    "{0}.{1}.{2}.{3} - - [{4}/{5}/{6}:{7}:{8}:{9}] {10} {11}://{12}{13} {14} {15}",
                    item.IpByte1, item.IpByte2,item.IpByte3,item.IpByte4,item.Date.Day,
                    item.Date.Month,item.Date.Year,item.Date.Hour,item.Date.Minute,
                    item.Date.Second,item.Method,
                    item.Protocol, item.FileName, item.FileExtension,item.StatusCode, item.NumberOfBytes);
            return result;
        }
    }
}
