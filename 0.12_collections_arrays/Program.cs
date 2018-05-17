using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_collections_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //--->Arrays are strongly typed. 
            //--->ERROR: string[] names = { 4, "John", "Paul", "George", "Ringo" };
            //---> Know the index offset
            //Index starts at 0. 0, 1, 2, 3, 4
            int[] ages = new int[5];
            ages[0] = 37;
            ages[1] = 40;
            ages[2] = 41;

            //----> print one specific index:
            Console.WriteLine(ages[2]);

            //----> print the whole array use a foreach:
            foreach (var age in ages)
            {
                Console.WriteLine($"Age is {age}");
            }
            //----> NOTE: foreach is readonly.
            foreach (var age in ages.Take(5))
            {
                Console.WriteLine(age);
            }

            //---->Arrays cannot grow in size once initialized.
            //A Challenge:
            //Iterate over an array with a for loop lets it be editable...
            Console.WriteLine("The Beatles");

            string[] names = { "JOHN", "PAUL", "GEORGE", "RINGO" };
            MoveArrayToList(names);


            void MoveArrayToList(string[] arr)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    string newName = arr[i].ToLower();
                    AddNameToList(newName);
                }
            }

            void AddNameToList(string newName)
            {
                List<string> insideName = new List<string>();
                insideName.Add(newName);

                foreach (var iName in insideName)
                {
                    Console.WriteLine(iName);
                }
            }
            Console.ReadLine();
        }
    }
}
