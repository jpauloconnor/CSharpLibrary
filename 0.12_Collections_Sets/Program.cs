using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists
            //HashSet<T>
            //SortedSet<T>
            //ISet<T>
            //Has no position in the list
            //Hash Table
            //Internal table no keys
            //No way to look up particular element
            //Must enumerate them
            //Guarantees uniqueness - won't have the same thing 2x

            Console.WriteLine("List Demo");
            ListDemo listDemo = new ListDemo();
            listDemo.AddToListAndPrintList("New Dude");

            SetDemo setDemo = new SetDemo();
            Console.WriteLine("         ");
            Console.WriteLine("Set Demo #1 - No duplicates");
            setDemo.AddToSetAndPrintSet("Horse Mange");

            Console.WriteLine("         ");
            Console.WriteLine("Set Demo #2 - Caps issues/Invariant Culture");
            setDemo.AddToSetAndPrintSet("HORSE MANGE");

            Console.ReadLine();
        }
    }
}
