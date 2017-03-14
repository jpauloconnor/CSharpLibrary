using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Encapsulation
{
    public class BankAccountPrivate     {
        //Customary to put an _ before private fields.
        private string _name;
        private int _accountNumber;

        public string CustomerName
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
