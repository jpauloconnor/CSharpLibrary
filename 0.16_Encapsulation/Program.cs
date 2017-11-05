/*Encapsulation is an object-oriented principle of hiding the internal state and behavior of an object.
It makes code more maintainable.  
For example, the public access modifier allows access to any code but the private access modifier restricts
access to only members of a type. Other access modifiers restrict access in the range somewhere between public
and private. While you can use any of the access modifiers on type members, the only two access modifiers you can
use on types are the public and internal. Here are a few for us to play around with.
*/

/******Keyword***************Applicable To***************Meaning******************************************		
        public 				  Class, Member				No restrictions
        protected			  Member					Access limited to the class and derived classes
        private				  Member					Access limited to the class.

        internal              Class, Member				Access limited to the current assembly		
    protected internal 		  Member					Access limited to current assembly and derived types

**********************************************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Review these files.

namespace _0._16_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountPublic bankAccount = new BankAccountPublic();
            decimal amount = bankAccount.GetAmount();
            Console.WriteLine("Your balance is {0}", amount);

            BankAccountPrivate bankAccountPrivate = new BankAccountPrivate();
            bankAccountPrivate.CustomerName = "John Paul Jones";

            BankAccountProtected bankAccountProtected = new BankAccountProtected();
            bankAccountProtected.CloseAccount();
            //Try calling any of the Protected methods on this. You can't do it.
            
            Console.ReadLine();
        }
    }
}
