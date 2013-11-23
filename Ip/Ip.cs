using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ip
{
    public class Ip
    {
        public byte IpByte1 { get; set; }
        public byte IpByte2 { get; set; }
        public byte IpByte3 { get; set; }
        public byte IpByte4 { get; set; }

        public static bool operator ==(Ip ip1, Ip ip2)
        {
            return
                (ip1.IpByte1 == ip2.IpByte1
                && ip1.IpByte2 == ip2.IpByte2
                && ip1.IpByte3 == ip2.IpByte3 &&
                ip1.IpByte4 == ip2.IpByte4);
        }

        public static bool operator !=(Ip ip1, Ip ip2)
        {
            return !(ip1 == ip2);
        }
    }
}
