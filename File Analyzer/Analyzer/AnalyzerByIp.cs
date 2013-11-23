using System.Collections.Generic;
using System.Linq;
using System.Text;
using File_Analyzer.Analyzer_Param;
using Journal_Record;

namespace File_Analyzer.Analyzer
{
    class AnalyzerByIp : IFileAnaluzer<StringBuilder>
    {
        public List<JournalRecord> RecordList { get; set; }

        private static bool ContainsIp(Ip.Ip ip, IEnumerable<Ip.Ip> ipList)
        {
            return ipList.Any(ip1 => ip1 == ip);
        }

        public StringBuilder Analyzer(ParametersAnalyzer parameters)
        {
            var result = new StringBuilder();
            var ipList = new List<Ip.Ip>();
            for (var i = 0; i < RecordList.Count; i++)
            {
                var ip = new Ip.Ip
                {
                    IpByte1 = RecordList.ElementAt(i).Ip.IpByte1,
                    IpByte2 = RecordList.ElementAt(i).Ip.IpByte2,
                    IpByte3 = RecordList.ElementAt(i).Ip.IpByte3,
                    IpByte4 = RecordList.ElementAt(i).Ip.IpByte4
                };
                if (ContainsIp(ip, ipList)) continue;
                ipList.Add(ip);
                result =
                    result.AppendLine(string.Format("{0}.{1}.{2}.{3}", ip.IpByte1, ip.IpByte2, ip.IpByte3,
                        ip.IpByte4));
            }

            return result;
        }
    }
}
