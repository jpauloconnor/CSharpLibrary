using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Interfaces_Collections_Pseudo
{
    class ListClass : ICollect, IConvert, IEnum, IListMethods
    {
        public void AddSomeStuff()
        {
            Console.WriteLine("You added something of just any type to the list.");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("So there's like 8 spots in the list here");
        }

        public void CountTheItems()
        {
            Console.WriteLine("You added something of just any type to the list.");
        }

        public void IterateOverTheCollection()
        {
            Console.WriteLine("let's run a foreach over the list");
        }

        public void MoveToArray()
        {
            Console.WriteLine("Ok, you oved this list to an array. Yea, you can do that");
        }

        public void RemoveSomeStuff()
        {
            Console.WriteLine("let's take some stuff out.");
        }

    }
}
