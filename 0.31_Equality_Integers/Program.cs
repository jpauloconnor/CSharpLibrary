using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31_Equality_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CheckEqualsForThree(1, 1, 1);
            Console.WriteLine("Result 1:{0}", result);
            result = CheckEqualsForThree(1, 2, 3);
            Console.WriteLine("Result 1:{0}", result);
            Console.ReadLine();
        }

        static string CheckEqualsForThree(int x, int y, int z)
        {
            string message;
            if (x == y && y.Equals(z))
                message = "The three numbers line up";
            else
                message = "they didn't match";
            return message;
        }
    }
}
