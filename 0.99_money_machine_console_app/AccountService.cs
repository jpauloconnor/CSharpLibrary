using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class AccountService
    {
        public void CreateAccount(string type, int customerId)
        {
            //There's a problem here with Random....What?
            Random random = new Random();
            int acctNum = random.Next(1, 5000);
            Random random = new Random();
            int pin = random.Next(1000, 10000);
            var entity = new Account()
            {
                AccountNumber = acctNum,
                AccountType = type,
                CustomerID = customerId,
                Pin = pin
            };
            using(var ctx = new AtmDBContextEntity())
            {
                ctx.Accounts.Add(entity);
                ctx.SaveChanges();
            }
            Console.WriteLine("Your id is:{0}", entity.AccountNumber);
        }

        //TODO:List Account Balance
        //TODO:List all Accounts by User
        //TODO:Delete Account
        //TODO:Edit Account Info
        //TODO:Set Account Pin#
        //TODO:Deal with type of Account

    }
}
