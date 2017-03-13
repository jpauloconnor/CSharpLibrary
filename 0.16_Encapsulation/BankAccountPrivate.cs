using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Encapsulation
{
    public class BankAccountPrivate     {
        private string name;
        private int accountNumber;

        public string CustomerName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
