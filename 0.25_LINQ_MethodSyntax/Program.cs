using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_LINQ_MethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository();
            var restaurants = restaurantRepository.Retrieve();
            var restaurantList = restaurantRepository.GetRestaurantNames(restaurants);

            var namesInReverse = restaurantRepository.PrintNamesInReverse(restaurants);
            foreach(var name in namesInReverse)
            {
                Console.WriteLine(name.Name);
            }
            Console.ReadKey();
        }
    }
}
