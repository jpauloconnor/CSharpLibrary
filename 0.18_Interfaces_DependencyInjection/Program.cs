using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to build this:
            
            //TODO 15 DI: create this instance. Notice that we pass in a new GoodCustomer()
            Customer goodCustomer = new Customer(new GoodCustomer());

            //TODO 16 DI: Call sendMessage on the Customer instance.
            goodCustomer.SendMessage();

            //TODO 19 DI: Create an instance of Customer. Notice that we can now pass in BadCustomer()
            Customer badCustomer = new Customer(new BadCustomer());

            //TODO 20 DI: Call the method on badCustomer?
            //What is the difference?
            badCustomer.SendMessage();

            //Task: Consider, manipulate, and study the program. How does DI affect a C# program?
                    //How can we use it in our favor?

        }
    }
}
