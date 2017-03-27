using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Acura acura = new Acura("TL", 2009, 50000);

            acura.AcuraDetails();

            Console.ReadLine();
        }
    }
}
