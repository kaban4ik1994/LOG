using System.Collections.Generic;
using System.Linq;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    static class InitializeTheListsOfUniqueIp
    {
        private static int NumberIpInListIp(Ip.Ip ip, IEnumerable<Ip.Ip> listIp)
        {
            return listIp.Count(ip1 => ip == ip1);
        }

        static public List<Ip.Ip> Generator(CreationOptionsValue parameters)
        {
            var parameter = (CreationOptionsIp)parameters;
            var tempIpList = new List<Ip.Ip>();
            var ipList = new List<Ip.Ip>();

            for (var i = 0; i < parameter.NumberOfUniqueIp; i++)
            {

                var ip = new Ip.Ip
                {
                    IpByte1 = (byte)parameter.Random.Next(1, 128),
                    IpByte2 = (byte)parameter.Random.Next(1, 254),
                    IpByte3 = (byte)parameter.Random.Next(1, 254),
                    IpByte4 = (byte)parameter.Random.Next(1, 254)
                };
                tempIpList.Add(ip);
            }

            for (var i = 0; i < parameter.NumberOfUniqueIp; i++)
            {
                var numberOfIdentical = parameter.Random.Next(parameter.MinNumberOfRepeatedIp,
                    parameter.MaxNumberOfRepeatedIp);
                for (var j = 0; j < numberOfIdentical; j++)
                {
                    ipList.Add(tempIpList.ElementAt(i));
                }
            }

            for (var i = 0; i < parameter.Count - ipList.Count; i++)
            //если не все апи, добавляем у которых мало повторений 
            {
                foreach (
                    var ip in tempIpList.Where(ip => NumberIpInListIp(ip, ipList) <= parameter.MaxNumberOfRepeatedIp))
                {
                    ipList.Add(ip);
                }
            }
            var numberIp = ipList.Count();
            for (var i = 0; i < parameter.Count - numberIp; i++)
            {
                ipList.Add(ipList.ElementAt(parameter.Random.Next(0, ipList.Count)));
            }
            return ipList;

            

        }
    }
}
