using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer paul = new Customer();
            paul.FirstName = "Paul";
            paul.LastName = "O'Connor";
            paul.AppearWealthy = false;
            paul.PrintCustomer();
            paul.Age = 40;
            paul.GetAge();
            Console.WriteLine(paul.PostInterest("Subaru Wagon"));
            Console.WriteLine(paul.GetCarType("Subaru"));

            Car newCar = new Car();
            newCar.Automatic = true;
            newCar.IsFast = true;
            newCar.Name = "Pinto";
            newCar.Price = 9000;

            Console.WriteLine("{0} owns a {1}, and it's in bad shape.", paul.FirstName, newCar.Name);  //In bad shape could be a bool.
            Console.WriteLine("I think it is worth about a ${0} bucks for a trade in.", newCar.Price);

            //A little bit of inheritance.
            SportsCar sportsCar = new SportsCar();
            sportsCar.MadeInUSA = true;
            sportsCar.Name = "Corvette";

            //NEEDS REFACTORING HERE VVVV
            if (sportsCar.MadeInUSA == true)
            {
                Console.WriteLine("He says he wouldn't mind owning a {0}, especially since they are made in the USA", sportsCar.Name);
            }
            else
            {
                Console.WriteLine("He has no interest in owning a {0}, especially since it was not made in the USA", sportsCar.Name);
            }

            Console.ReadLine();
        }
    }
}
