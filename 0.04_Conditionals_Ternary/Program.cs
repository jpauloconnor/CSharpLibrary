using System;

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

            Console.ReadLine();

        }
    }
}
