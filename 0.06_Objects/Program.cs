using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Donut #1
            Donut special = new Donut();
            special.Filling = "Cream";
            special.IsSpecial = true;
            special.Price = 0.99M;
            special.Type = "The Goliath Beast";

            Console.WriteLine(special.Filling);
            Console.ReadLine();
        }
    }
}
