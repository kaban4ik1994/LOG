using System.Collections.Generic;
using System.Linq;
using System.Text;
using File_Analyzer.Analyzer_Param;
using File_Analyzer.Result_Analyzer;
using Journal_Record;


namespace File_Analyzer.Analyzer
{
    class AnalyzerByIp : IFileAnaluzer<ResultAnalyzerByIp,ParametersAnalyzerByIp>
    {
        public List<JournalRecord> RecordList { private get; set; }

        private static bool ContainsIp(Ip.Ip ip, IEnumerable<Ip.Ip> ipList)
        {
            return ipList.Any(ip1 => ip1 == ip);
        }

        public ResultAnalyzerByIp Analyz(ParametersAnalyzerByIp parameters)
        {
            var result = new ResultAnalyzerByIp
            {
                Result = new List<Ip.Ip>()
            };
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
                result.Result.Add(ip);
            }
            return result;
        }
    }
}
