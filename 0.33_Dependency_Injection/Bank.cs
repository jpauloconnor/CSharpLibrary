using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._33_Dependency_Injection
{
    class Bank : IService
    {
        public string Name { get; set; }

        public void Serve()
        {
            Console.WriteLine("The bank can take that out of your savings");
        }
    }
}
