using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenges
{
    class MobilePhone
    {
        public MobilePhone(string brand, string version)
        {
            this.Brand = brand;
            this.Version = version;
        }
        public string Brand { get; set; }
        public string Version { get; set; }
    }
}
