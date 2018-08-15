using _0._06_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_collections_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("cat", "annoying creature");
            dictionary.Add("dog", "man's best friend");

            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }


            Dictionary<string, Element> periodicTable = new Dictionary<string, Element>();
            periodicTable.Add("K", new Element() { Symbol = "K", Name = "Potassium", AtomicNumber = 19 });
            periodicTable.Add("Sr", new Element() { Symbol = "Sr", Name = "Strontium", AtomicNumber = 38 });

            foreach(var e in periodicTable)
            {
                Console.WriteLine(e.Key + ' ' + e.Value.Name);
            }
            Console.ReadLine();
        }
    }
}
