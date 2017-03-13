using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string paulsPhone = "I own the ";
            MobilePhone myPhone = new MobilePhone("iPhone", "6");
            Console.WriteLine(paulsPhone + myPhone.Brand + " " + myPhone.Version + ".");
            Console.ReadLine();
        }
    }
}
