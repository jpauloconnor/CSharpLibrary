using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31_Equality_structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates myLocation = new Coordinates(1.24f, 1.32f);
            Coordinates yourLocation = new Coordinates(1.24f, 1.32f);

            if(myLocation.Equals(yourLocation))
                Console.WriteLine("We are at the same spot!");
            if(!myLocation.Equals(yourLocation))
                Console.WriteLine("Where you at?");


        }
    }
}
