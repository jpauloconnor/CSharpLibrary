using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Intervaces_Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.StateName();
        }
    }



    interface IPerson1
    {
        void StateName();
    }

    interface IPerson2 : IPerson1
    {
        void StateLastName();
    }

    interface IPerson3
    {
        void StateAwesome();
    }

    public class Person : IPerson2
    {
        public void StateName()
        {
            Console.WriteLine("My name is Jonas");
        }
        public void StateLastName()
        {
            Console.WriteLine("O'Connor");
        }
    }


    public class Paul : Person, IPerson3
    {
        public void StateAwesome()
        {
            Console.WriteLine("Awesome");
        }
    }
}
