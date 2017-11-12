using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{ 
    class AuthService
    {
        private AtmDBContextEntities db = new AtmDBContextEntities();
        private CustomerService customerService = new CustomerService();

        public int RequestAccountNumber()
        {
            Console.WriteLine("Please swipe your card or enter your unique account number: ");
            string accountNumber = Console.ReadLine();
            int accountNumberConverted = Int32.Parse(accountNumber);
            return accountNumberConverted;
        }

        public int RequestPinNumber()
        {
            Console.WriteLine("Please enter your pin");
            string pinNumber = Console.ReadLine();
            int pinNumberConverted = Int32.Parse(pinNumber);
            return pinNumberConverted;
        }

        public bool VerifyUser(int account, int pin)
        {
            var query = from n in db.Accounts
                        where n.AccountNumber == account && n.Pin == pin
                        select n;

            foreach (var acc in query)
            {
                if (acc == null)
                {
                    Console.WriteLine("We can't seem to find you in our database.");
                    return false;
                }
                else
                {
                    customerService.GreetByLast(acc.AccountID);
                    Console.WriteLine("You are verified");
                    return true;
                }
            }
            Console.WriteLine("User does not exist");
            return false;
        }

        public void EditAccountPin()
        {
            //Already logged into account
            //Want to change pin on Account

        }

    }
}
