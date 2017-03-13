using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces
{
    class Person : IPerson, IPerson2
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayHelloInAnotherLanguage()
        {
            Console.WriteLine("Hola");
        }
    }
}
