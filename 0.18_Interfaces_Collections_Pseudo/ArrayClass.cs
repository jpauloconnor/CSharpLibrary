using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_Collections_Pseudo
{
    class ArrayClass : IListMethods, ICollect, IEnum
    {
        public void AddSomeStuff()
        {
            Console.WriteLine("You can't add stuff to an array, bro!");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Arrays don't have a capacity. That's a list, bro!");
        }

        public void CountTheItems()
        {
            Console.WriteLine("Count the number of items in the array. Start at 0.");
        }

        public void IterateOverTheCollection()
        {
            Console.WriteLine("Iterate over the array");

        }

        public void RemoveSomeStuff()
        {
            throw new NotImplementedException("You can't remove stuff from an array, yo.");
        }
    }
}
