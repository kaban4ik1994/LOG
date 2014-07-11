using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorIp : IFileGenerator<Ip.Ip>
    {
        private List<Ip.Ip> _listOfIp=new List<Ip.Ip>();

        public Ip.Ip Generator(CreationOptionsValue parameters)
        {
            var parameter = (CreationOptionsIp) parameters;
            if (_listOfIp.Count == 0)
            {
               _listOfIp=InitializeTheListsOfUniqueIp.Generator(parameter);
            }
            var position = parameter.Random.Next(0, _listOfIp.Count);
            var ip = _listOfIp.ElementAt(position);
            _listOfIp.Remove(ip);
            return ip;
        }
    }
}
       