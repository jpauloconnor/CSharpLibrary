using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can create an Object from the base class if the base class is not abstract.
            Animal georgeTheAnimalSteel = new Animal();
            georgeTheAnimalSteel.GetMad();

            //A few objects built from subclasses of Animal.

            Bear barryTheBear = new Bear();
            barryTheBear.LatinName = "Ursidae";
            barryTheBear.GetMad();
            barryTheBear.EatHiker();
            barryTheBear.numberOfSalmonPerDay = 10;
            barryTheBear.StateType();

            Cat coryTheCat = new Cat();

            Console.ReadLine();
        }
    }
}
