using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool AppearWealthy { get; set; }

        public void PrintCustomer()
        {
            Console.WriteLine("His name is {0} {1}", FirstName, LastName);
        }

        public void AssessWealth()
        {

            if (AppearWealthy == true)
            {
                Console.WriteLine("He does appear wealthy.");
            }
            else
            {
                Console.WriteLine("He doesn't appear wealthy.");
            }
        }
    }
}
