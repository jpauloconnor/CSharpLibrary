using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Sets
{
    class SetDemo
    {
        /// <summary>
        /// Sets up a HashSet and takes a new item....
        /// </summary>
        /// <param name="newItem"></param>
        public void AddToSetAndPrintSet(string newItem)
        {
            //Here's a list:
            var consoleEnemies = new HashSet<string>
            //Instead of empty param try this for caps duplicates:
            (StringComparer.InvariantCultureIgnoreCase)
            {
                "Horse Mange", "Troll Rabbit", "Rolphe"
            };

            //We can't add duplicates:
            consoleEnemies.Add(newItem);
            
            //Print the set out with foreach
            foreach (string enemy in consoleEnemies)
            {
                Console.WriteLine(enemy);
            }
        }
    }
}
