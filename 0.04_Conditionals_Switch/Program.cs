using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Fred";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    break;
                case "Karl":
                    Console.WriteLine("Let's hang.");
                    break;
                case "John":
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default:
                    Console.WriteLine("Hey " + friend + "can I call you back in a minute>");
                    break;
            }

            Console.ReadLine();
        }
    }
}
