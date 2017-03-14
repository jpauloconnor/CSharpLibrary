using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number == 7)
                Console.WriteLine("The number is 7");
            else
                Console.WriteLine("The number is not 7");

            //Same as this:

            string response = ((number == 7) ? "hey, The number is 7, yo" : "The number is not 7, yo");
            Console.WriteLine(response);

            //Variation on Old Microsoft Docs
            //Says Good evening or Good day
            //https://msdn.microsoft.com/en-us/library/zakwfxx4(v=vs.100).aspx
            
            //USING IF
            var rightNow = new DateTime();
            var greet = "Good";
            if (rightNow.Hour > 17)
                greet += " evening.";
            else
                greet += " day.";

            Console.WriteLine(greet);

            //TERNARY VERSION
            var now = new DateTime();
            var greeting = "Good" + ((now.Hour> 17) ? " evening." : " day.");
            Console.WriteLine(greeting);
            Console.WriteLine(now.Hour);

            Console.ReadLine();

        }
    }
}
