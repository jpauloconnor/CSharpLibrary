using System;

namespace _0._15_Polymorphism
{
    public class Car
    {
        //These fields have to be public to be usable in the subclasses.
        public string carMake = "Ford";
        public string carModel = "Fairlane";

        //We need this virtual keyword to override the method in the subclasses.
        public virtual void PrintCarName()
        {
            Console.WriteLine("{0} {1}", carMake, carModel);
        }
    }
}