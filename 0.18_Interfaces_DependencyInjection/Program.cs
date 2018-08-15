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
            Customer goodCustomer = new Customer(new GoodCustomer());
            goodCustomer.SendMessage();

            Customer badCustomer = new Customer(new BadCustomer());
            badCustomer.SendMessage();
        }
    }
}
