using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._28_MathFacts
{
    class Multiplication
    {
        public void MultiplicationTable(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                    Console.Write(String.Format("{0,6}", "n"));
                else
                    Console.Write(String.Format("{0,6}", i));
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++) //rows
            {
                Console.Write(String.Format("{0,6}", i));
                for (int b = startNum; b <= endNum; b++)// collumns
                {
                    string output = String.Format("{0,6}", i * b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }
        }

        public void MultiplicationTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @" _____     _ _   _     _ _         _   _            _____     _   _     
|     |_ _| | |_|_|___| |_|___ ___| |_|_|___ ___   |_   _|___| |_| |___ 
| | | | | | |  _| | . | | |  _| .'|  _| | . |   |    | | | .'| . | | -_|
|_|_|_|___|_|_| |_|  _|_|_|___|__,|_| |_|___|_|_|    |_| |__,|___|_|___|
                  |_|                                                   ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will see the numbers between these selections be multiplied");
            Console.WriteLine("to numbers 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10");
        }
    }
}
