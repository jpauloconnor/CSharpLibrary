using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Encapsulation
{
    public class BankAccountProtected
    {
        public void CloseAccount()
        {
            ApplyLateCharges();
            CalculateInterest();
        }

        protected virtual void ApplyLateCharges()
        {
            // deduct from account
        }

        protected virtual void CalculateInterest()
        {
            // add to account
        }

    }
}
