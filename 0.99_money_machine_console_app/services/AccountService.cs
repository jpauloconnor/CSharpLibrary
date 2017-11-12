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
        TransactionService transactionService = new TransactionService();

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

        public int AddDepositToBalance(int deposit, Account account)
        {
            int accountBalance;
            accountBalance = account.Balance ?? default(int);

            var x = transactionService.DepositTransaction(deposit);
            int newBalance = accountBalance + x;

            return newBalance;
        }
       
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






        //Withdrawl Menu
        //$20 Quick Cash...................................1
        //$100 Quick Cash..................................2


        //Deposit Menu
        //Check............................................1
        //Cash.............................................2



    }
}
