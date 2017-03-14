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
            Console.WriteLine("Apply Late Charges ran.");
        }

        protected virtual void CalculateInterest()
        {
            Console.WriteLine("Calculate Interest ran.");
        }
    }
}
