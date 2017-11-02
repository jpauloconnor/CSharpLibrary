using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_Collections_Pseudo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListClass customListClass = new ListClass();

            customListClass.AddSomeStuff();
            customListClass.CheckTheCapacity();

            ArrayClass customArrayClass = new ArrayClass();
            customArrayClass.CheckTheCapacity();

        }
    }
}
