using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_money_machine_console_app
{
    class WithdrawService
    {
        private AtmDBContextEntities db = new AtmDBContextEntities();

        public int WithdrawMoney(int withdraw, int transId)
        {
            var entity = new Withdrawl
            {
                Amount = withdraw,
                TransactionID = transId
            };
            using (var ctx = new AtmDBContextEntities())
            {
                ctx.Withdrawls.Add(entity);
                ctx.SaveChanges();
            }
            return entity.Amount;
        }
    }
}
