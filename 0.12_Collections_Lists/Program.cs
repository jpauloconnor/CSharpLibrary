using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Talk about built in methods. Add more.
namespace _0._12_Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here's an example of a List
            List<string> conceptList = new List<string>
            {
                "Stuff"
            };
            conceptList.Add("Types");
            conceptList.Add("Strings");
            conceptList.Add("Booleans");
            conceptList.Add("Ints");
            conceptList.Add("Floats");
            conceptList.Add("Doubles");

            foreach (var concept in conceptList)
            {
                Console.WriteLine(concept);
            }

            //Two properties that a List has:
            // A list is a reference to an array that has extra spaces. 
            //Notice the count property & capacity propery.
            Console.WriteLine("Count before:", conceptList.Count);
            Console.WriteLine("Capacity before:", conceptList.Capacity);

            conceptList.Add("Decimals");
            conceptList.Add("Methods");
            conceptList.Add("Loops");
            conceptList.Add("Public versus Private");


            Console.WriteLine(conceptList[0]);
            Console.WriteLine("");
            Console.WriteLine("Example of ForEach and Lambda");
            conceptList.ForEach(concept => Console.WriteLine(concept));


            Console.WriteLine("/******************************************************/");

            //Notice the param below sets the capacity to 10.
            List<string> names = new List<string>(10)
            {
                "James", "Paul", "Kenn", "Jenn", "Sheriff"
            };

            //Two properties that a List has:
            // A list is a reference to an array that has extra spaces. 
            //Notice the count property & capacity propery.
            Console.WriteLine(names.Count);
            Console.WriteLine(names.Capacity);
            names.ForEach(name => Console.WriteLine(name));
            names.Remove("James");

            names.ForEach(name => Console.WriteLine(name));
            names.ForEach(name => Console.WriteLine(name));
            names.Remove("James");
            Console.WriteLine("================");
            names.ForEach(name => Console.WriteLine(name));


            Console.WriteLine("/******************************************************/");

            
            //List<T> has a lot of the same elements as arrays.


            Console.ReadLine();


        }
    }
}
