using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just goofing around here. Play with a bunch of conditions.
            var bankAccount = 10000;
            var debt = 4200;
            var difference = bankAccount - debt;

            Console.WriteLine("I have $" + bankAccount + " in my bank account, and I am $" + debt + " in debt.");

            if (difference >= 700 && difference <= 1999)
            {
                Console.WriteLine("I have some extra money. I should pay off my debt. I'll have $" + difference + " leftover.");
            }
            else if ((bankAccount - debt > 2000))
            {
                Console.WriteLine("I have a ton of extra cash right now. I think I could go to Europe!");
            }
            else
            {
                Console.WriteLine("It probably isn't a good time to pay off my debt.");
            }
            Console.Read();
        }
    }
}
