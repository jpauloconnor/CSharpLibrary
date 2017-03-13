using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Create more basic examples.
namespace _0._17_GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notice we have the potential for invalid conditions. Ugh.

            ElevenFiftyEmployee paul = new ElevenFiftyEmployee();
            paul.Id = 10;
            paul.Name = "Paul O'Connor";
            paul.CommonWorkQuote = "Somebody's got a case of the Mondays";
            paul.CompanyName = "Eleven Fifty";

            Console.WriteLine("{0} {1} {2}", paul.Id, paul.Name, paul.CompanyName);
            Console.ReadLine();
        }
    }
}
