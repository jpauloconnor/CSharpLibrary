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
                    Console.WriteLine("You are verified");
                    return true;
                }
            }
            Console.WriteLine("User does not exist");
            return false;
        }
    }
}
