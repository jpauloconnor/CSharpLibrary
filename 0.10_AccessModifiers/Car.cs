using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Demo for protected, private, etc.
namespace _0._10_AccessModifiers
{
    public class Car
    {
        //Noitice that this private int can't be accessed outside of the class.
        private int actualCost = 50000;
        public int customerPrice;

        public string name { get; set; }

        public void CalculateGain()
        {
            int gain = customerPrice - actualCost;
            if (gain >= 25000)
            {
                Console.WriteLine("This would be a good customer price for this car.");
            }
            else
            {
                Console.WriteLine("That price is too low for us to make a profit.");
            }

        }

    }
}


/******Keyword***************Applicable To***************Meaning******************************************		
        public 				  Class, Member				No restrictions
        protected			  Member					Access limited to the class and derived classes
        private				  Member					Access limited to the class.

        internal              Class, Member				Access limited to the current assembly		
    protected internal 		  Member					Access limited to current assembly and derived types

**********************************************************************************************************/

