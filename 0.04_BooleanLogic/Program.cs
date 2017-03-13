using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Ternary Operator, Switch

            bool isOn = true;
            bool isHot = false;

            //1
            if (isOn)
            {
                Console.WriteLine("The light is on. It's bright.");
            }

            //2
            if (isOn == true)
            {
                Console.WriteLine("The light is on");
            }

            //3
            if (isOn && isHot)
            {
                Console.WriteLine("Lights on and it's hot");
            }

            //4
            if (isOn || isHot)
            {
                Console.WriteLine("lights on or it is hot");
            }

            //5
            if (!isHot)
            {
                Console.WriteLine("it is not hot");
            }
        }
    }
}
