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

        AccountService accountService = new AccountService();
        DepositService depositService = new DepositService();

        /*TODO: Method for withdrawl*/
        public void WithdrawlMoney() { }

        public int DepositTransaction(int depositEntered)
        {
            int deposit = depositService.DepositMoney(depositEntered);
            return deposit;
        }

        /*TODO: Method for moving stuff to another account */
        /*TODO: */
    }
}
