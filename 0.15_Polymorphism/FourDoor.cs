using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Polymorphism
{
    public class FourDoor : Car
    {
        public override void PrintCarName()
        {
            Console.WriteLine("{0} {1} Four Door Sedan", carMake, carModel);
        }
    }
}
