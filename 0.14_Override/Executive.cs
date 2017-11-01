using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Executive : Employee
    {
        //TODO: Do something with the stock options.
        //So an executive gets stock at 1/2 price or something. Up to 100 shares. I dunno.

        // New field that will affect the base pay.
        private decimal stockOptions;


        // The constructor calls the base-class version, and
        // initializes the salesbonus field.
        public Executive(string name, decimal basepay, decimal stockOptions) : base(name, basepay)
        {
            this.stockOptions = stockOptions;
        }

        // Override the CalculatePay method to take bonus into account.
        public override decimal CalculatePay()
        {
            return basepay + stockOptions;
        }
    }
}
