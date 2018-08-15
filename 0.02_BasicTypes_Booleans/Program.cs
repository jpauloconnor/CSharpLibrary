using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Booleans
{
    class Program
    {
        static void Main(string[] args)
        {

            //Somewhat from the Docs: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/bool

            bool b = true;
            // WriteLine automatically converts the value of b to text.
            Console.WriteLine(b);

            //This will grab the number out of 365
            int currentDay = DateTime.Now.DayOfYear;
            Console.WriteLine(currentDay);

            // Assign the result of a boolean expression to b.
            b = (currentDay % 2 == 0); 

            // Branch depending on whether b is true or false.
            if (b)
            {
                Console.WriteLine("Today is an even number day.");
            }
            else
            {
                Console.WriteLine("Today is an odd number day.");
            }


            //This gets into prebuilt methods that return booleans.

            Console.Write("Enter a character: ");
            char c = (char)Console.Read();

            if (Char.IsDigit(c))
            {
                Console.WriteLine(c + " is a digit");
            }

            //Another method that returns a Boolean
            if (Char.IsPunctuation(c))
            {
                Console.WriteLine(c + " is punctuation.");
            }
            
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine(c + " is lowercase");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The character is uppercase.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Not an alphabetic character.");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
