using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Finish out the challenges. Organize this better.
namespace _0._12_Arrays_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] indyWinners = { "Juan Pablo Montoya", "Ryan Hunter-Reay", "Tony Kanaan", "Dario Franchitti", "Dan Wheldon" };

            //Looping over the array
            foreach (string element in indyWinners)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();

        }
    }
}
