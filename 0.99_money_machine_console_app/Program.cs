using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var accountService = new AccountService();

            Console.WriteLine("Create a new customer. First Name.");
            var first = Console.ReadLine();
            Console.WriteLine("Create a new customer. Last Name.");
            var last = Console.ReadLine();
            customerService.CreateCustomer(first, last);

            Console.WriteLine("Hello {0} you like to create a new account?");
            var type = Console.ReadLine();

            Console.WriteLine("What is your customer ID?");
            var customerID = Console.ReadLine();
            int convertedCustomerID = Int32.Parse(customerID);
            customerService.GetId(convertedCustomerID);
            accountService.CreateAccount(type, convertedCustomerID);

            Console.ReadLine();
        }
        static CustomerService CreateCustomerService()
        {
            var service = new CustomerService();
            return service;
        }

        static AccountService CreateAccountService()
        {
            var service = new AccountService();
            return service;
        }

    }
}
