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
            //------> Index starts at 0. 0, 1, 2, 3, 4
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

            //Numbers are for the steps it walks through
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

            string[] namesIsaac = new string[] { "PAUL", "GEORGE", "JOHN", "RINGO" };

            int j = 0;
            //Turn each item in names array to lowercase    
            foreach (string name in namesIsaac)
            {
                namesIsaac[j] = namesIsaac[j].ToLower();
                j++;
            }

            Console.WriteLine("Printing names array");
            Console.WriteLine();

            int counter = 0;
            //Print each item in names array
            foreach (string name in namesIsaac)
            {
                Console.WriteLine(namesIsaac[counter]);
                counter++;
            }

            Console.WriteLine();
            //Feed each item in names array
            List<string> newNames = new List<string>();

            int k = 0;
            foreach (string name in namesIsaac)
            {
                newNames.Add(namesIsaac[k]);
                k++;
            }

            Console.WriteLine("Printing newNames list");
            Console.WriteLine();

            //Print each item in list
            foreach (string name in newNames)
            {
                Console.WriteLine(name);
            }


            Console.ReadLine();
        }
    }
}
