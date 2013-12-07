
namespace Ip
{
    public class Ip
    {
        private bool Equals(Ip other)
        {
            return IpByte1 == other.IpByte1 && IpByte2 == other.IpByte2 && IpByte3 == other.IpByte3 && IpByte4 == other.IpByte4;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Ip) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = IpByte1.GetHashCode();
                hashCode = (hashCode*397) ^ IpByte2.GetHashCode();
                hashCode = (hashCode*397) ^ IpByte3.GetHashCode();
                hashCode = (hashCode*397) ^ IpByte4.GetHashCode();
                return hashCode;
            }
        }

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
