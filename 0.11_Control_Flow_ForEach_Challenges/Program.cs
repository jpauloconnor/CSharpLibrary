using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Control_Flow_ForEach_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            /*** BRONZE ***/
            foreach (var ch in "Hello World")
            {
                Console.WriteLine("{0}", ch);   // strings are just linked lists of chars
            }

            /*** SILVER ***/

            // that was the same as ...
            foreach (char ch in "Hello World") Console.WriteLine("{0}", ch); // single lines can omit braces

            Console.WriteLine(" ");


            /*** GOLD ****/
            char[] chars = new char[4];

            chars[0] = '\x0050';
            chars[1] = '\x0061';
            chars[2] = '\x0075';
            chars[3] = '\x006C';

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
    }
}
