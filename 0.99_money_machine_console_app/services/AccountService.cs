using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class AccountService
    {
        private AtmDBContextEntities db = new AtmDBContextEntities();

        public void CreateAccount(string type, int customerId)
        {
            //There's a problem here with Random....What?
            Random random = new Random();
            int acctNum = random.Next(1, 5000);
            Random randomTwo = new Random();
            int pin = randomTwo.Next(1000, 10000);
            var entity = new Account()
            {
                AccountNumber = acctNum,
                AccountType = type,
                CustomerID = customerId,
                Pin = pin
            };
            using(var ctx = new AtmDBContextEntities())
            {
                ctx.Accounts.Add(entity);
                ctx.SaveChanges();
            }
            Console.WriteLine("Your id is:{0}", entity.AccountNumber);
        }

       
        public void LogInUser(int accountNum, int pin)
        {
            Console.WriteLine("You are now logged in");
        }

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

        /// <summary>
        /// EditAccountPin
        /// </summary>
        public void EditAccountPin()
        {
            //Already logged into account
            //Want to change pin on Account
            
        }
  
        /// <summary>
        /// EditAccountName
        /// </summary>
        public void EditAccountName(){ }

        //TODO:List Account Balance
        public void ListAccountBalance()
        {
            Console.WriteLine("Your Account Balance is");
        }

        //TODO:List all Accounts by User
        public void ListAllUserAccounts() { }

        //TODO:Delete Account
        public void DeleteAccount() { }

        //TODO:Set Account Pin#
        //TODO:Deal with type of Account

        public int CreatePin(int account)
        {
            var pin = account;
            return pin;
        }

        //Security: Secret Pin
        //Hash Pin: https://stackoverflow.com/questions/4181198/how-to-hash-a-password


    }
}
