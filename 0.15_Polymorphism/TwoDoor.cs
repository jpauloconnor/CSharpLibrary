using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Polymorphism
{
    public class TwoDoor : Car
    {
        //Must have the override keyword.
        public override void PrintCarName()
        {
            Console.WriteLine("{0} {1} Two Door Coupe", carMake, carModel);
        }
    }
}
