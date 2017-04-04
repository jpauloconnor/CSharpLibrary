using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_base
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using construtor 1
            Person kenn = new Person();
            kenn.FirstName = "Kenn";
            kenn.LastName = "Pascascio";
            kenn.Age = 40;
            kenn.TestMethod();

            //Using constructor 2
            Person kenn2 = new Person("Kenny", "Pascascio", 40);
            kenn2.TestMethod();
            
            Minor sophia = new Minor("Sophia", "O'Connor", 4, true);
            sophia.DemoMethod();
            sophia.TestMethod();

            Person jenn = new Minor("Jenn", "Aikins", 17, true);
            jenn.TestMethod();


            Console.ReadLine();







            //Person chris = new Person("Chris", "Sullivan");
            //chris.TestMethod();








            

            


        }
    }
}
