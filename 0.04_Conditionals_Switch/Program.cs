using System;

namespace _0._04_Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 7;

            switch (age)
            {
                case 7:
                    Console.WriteLine("You are 7");
                    break;
                default:
                    break;
            }

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
