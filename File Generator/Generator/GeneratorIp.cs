using System;
using System.Collections.Generic;
using System.Linq;
using File_Generator.Generator_Param;

namespace File_Generator.Generator
{
    class GeneratorIp : IFileGenerator<Ip.Ip, CreationOptionsIp>
    {
        private List<Ip.Ip> _listOfIp=new List<Ip.Ip>();

        public Ip.Ip Generator(CreationOptionsIp parameters)
        {
            if (_listOfIp.Count == 0)
            {
               _listOfIp=InitializeTheListsOfUniqueIp.Generator(parameters);
            }
            var position = parameters.Random.Next(0, _listOfIp.Count);
            var ip = _listOfIp.ElementAt(position);
            _listOfIp.Remove(ip);
            return ip;
        }
    }
}
       