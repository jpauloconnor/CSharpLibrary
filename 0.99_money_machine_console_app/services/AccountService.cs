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
            Random randomPin = new Random();
            int pin = randomPin.Next(1000, 10000);
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
        public int GetBalance(int accountID)
        {
            if (accountID == null)
            {
                Console.WriteLine("Sorry, we didn't catch that number.");
            }
            Account account = db.Accounts.Single(accountNumber => accountNumber.AccountNumber == accountID);
            if (account == null)
            {
                Console.WriteLine("Are you sure you're sure?");
            }
            Console.WriteLine("Your account balance is: ${0}", account.Balance);
            return account.Balance;
        }
        public int CreatePin(int account)
        {
            var pin = account;
            return pin;
        }
        public int AddDepositToBalance(int accountNum, int deposit, int currentBalance)
        {
            if (accountNum == null)
            {
                Console.WriteLine("Sorry, we didn't catch that number.");
            }
            Account account = db.Accounts.Single(accountNumber => accountNumber.AccountNumber == accountNum);
            if (account == null)
            {
                Console.WriteLine("Are you sure you're sure?");
            }
            Console.WriteLine("Your account balance is: ${0}", account.Balance);
            currentBalance = account.Balance;
            int newBalance = deposit + currentBalance;
         
            Console.WriteLine("Your new balance will be {0}. Does that look correct?", newBalance);
            return newBalance;
        }
        public bool SaveNewBalanceToDatabase(int acctNum, int newBalance)
        {
            //var entity = new Account()
            //{
            //    AccountNumber = acctNum,
            //    Balance = newBalance
            //};
            using (var ctx = new AtmDBContextEntities())
            {
                var entity =
                    ctx
                        .Accounts
                        .Single(e => e.AccountNumber == acctNum);
                entity.AccountNumber = acctNum;
                entity.Balance = newBalance;

                return ctx.SaveChanges() == 1;
            }
            Console.WriteLine("Your balance was saved.");
        }

        //TODO: What's this?
        public void EditAccountName() { }
        //TODO:List all Accounts by User
        public void ListAllUserAccounts() { }
        //TODO:Delete Account
        public void DeleteAccount() { }
        //TODO:Set Account Pin#
        //TODO:Deal with type of Account

        //Other ideas:
        //Security: Secret Pin
        //Hash Pin: https://stackoverflow.com/questions/4181198/how-to-hash-a-password

        //Withdrawl Menu
        //$20 Quick Cash...................................1
        //$100 Quick Cash..................................2

        //Deposit Menu
        //Check............................................1
        //Cash.............................................2



    }
}
