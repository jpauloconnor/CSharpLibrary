using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Probably one of the biggest examples of using an override....

            Car impala = new Car();
            impala.Year = 2000;

            impala.Make = "Chevy";
            impala.Model = "Impala";
            Console.WriteLine(impala);
            Console.ReadLine();
        }
    }
}
