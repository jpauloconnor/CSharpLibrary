using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Try_Catch
{
    class Age
    {
        int age = 0;
        public void showAge()
        {
            if (age >= 115)
            {
                throw (new AgeException("Humans don't usually live that long. Make sure you are entering the right age."));
            }
            //We can add other exception handling here as if else. Negative numbers? 

            else
            {
                Console.WriteLine("{0} years old", age);
            }
        }
    }
}
