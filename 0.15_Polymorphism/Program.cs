using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Review this code for correctness and clarity.

namespace _0._15_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we set up an array of objects.
            Car[] cars = new Car[3];

            //The first one will use the default fields and default method.
            cars[0] = new Car();

            //Just changing the carModel field in the next 2.
            cars[1] = new TwoDoor();
            cars[1].carModel = "Focus";

            cars[2] = new FourDoor();
            cars[2].carModel = "Taurus";


            //Polymorphism allows you to use derived class methods along with base class reference variables at run time.
            //Here we're using a base class variable - car - to run all of the subclasses/derived class methods - PrintCarName at run time.
            foreach (Car car in cars)
            {
                car.PrintCarName();
            }

            Console.ReadLine();
        }
    }
}
