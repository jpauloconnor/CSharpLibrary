using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Sets
{
    class ListDemo
    {

        /// <summary>
        /// Sets up a list and takes a new item....
        /// </summary>
        /// <param name="newItem"></param>
        public void AddToListAndPrintList(string newItem)
        {
            //1. Here's a list:
            var consoleEnemies = new List<string>
            {
                "Horse Mange", "Troll Rabbit", "Rolphe"
            };

            //2. We can add duplicates:
            consoleEnemies.Add("Darth Templator");
            consoleEnemies.Add(newItem);
            //3. check with foreach
            foreach (string enemy in consoleEnemies)
            {
                Console.WriteLine(enemy);
            }
        }
    }
}
