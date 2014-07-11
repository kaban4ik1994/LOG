using System.Collections.Generic;
using System.IO;
using System.Text;
using Convert_Item_To_String;
using Journal_Record;
namespace SaveToFile
{
    public class SaveToFile
    {
        public static void SaveToFileRecords(List<JournalRecord> records, string filePath)
        {
            var result = new StringBuilder();
            var converter=new ConvertItemToString();
            var streamWriter=new StreamWriter(filePath);
            for (var i = 0; i < records.Count - 1; i++)
            {
                result.AppendLine(converter.ConvertToString(records[i]));
            }
            result.Append(converter.ConvertToString(records[records.Count-1]));
            streamWriter.Write(result);
            streamWriter.Close();
        }
    }
}
