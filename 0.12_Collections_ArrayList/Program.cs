using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList.
            ArrayList demoArrayList = new ArrayList();
            demoArrayList.Add("Hello");
            demoArrayList.Add("World");
            demoArrayList.Add("!");
            demoArrayList.Add(1);
            demoArrayList.Add(4);

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("    Count:    {0}", demoArrayList.Count);
            Console.WriteLine("    Capacity: {0}", demoArrayList.Capacity);
            Console.Write("    Values:");
            
        }
    }
}
