using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class DepositService
    {
        private AtmDBContextEntities db = new AtmDBContextEntities();

        public int DepositMoney(int deposit, int transId)
        {
            var entity = new Deposit
            {
                Amount = deposit,
                TransactionID = transId
            };
            using (var ctx = new AtmDBContextEntities())
            {
                ctx.Deposits.Add(entity);
                ctx.SaveChanges();
            }
            return entity.Amount;

        }


        public void ShowDeposit() {  }
        public void ShowAllDeposits() { }

    }
}


        //TODO: add a deposit.
       
        //public int ShowDeposit(Transaction n)
        //{
        //var query = from n in db.Deposits
        //            where n.DepositID == name; 
        //            select n;
        //foreach (var name in query)
        //{
        //    Console.WriteLine("Hello, {0}", name.Customer.FirstName);
        //}
        //return 0;
        //}
//    }
//}
