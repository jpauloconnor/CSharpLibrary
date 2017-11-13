using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class TransactionService
    {
        private AtmDBContextEntities db = new AtmDBContextEntities();

        private AccountService accountService = new AccountService();
        private DepositService depositService = new DepositService();

        public int CreateTransaction(string transType, int accountNum)
        {
            var entity = new Transaction
            {
                TransactionType = transType,
                AccountID = accountNum
            };
            using (var ctx = new AtmDBContextEntities())
            {
                ctx.Transactions.Add(entity);
                ctx.SaveChanges();
            }
            Console.WriteLine(entity.TransactionID);
            return entity.TransactionID;
        }
        
       
    }
}
/*TODO: Method for moving stuff to another account */
