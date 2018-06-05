using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._32_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var favoriteShows = "the wire";
            //Makes helper method more discoverable, easier to call
            var fixedCaseTitle = favoriteShows.ConvertToTitleCase();
            Console.WriteLine(fixedCaseTitle);
            Console.ReadKey();
        }
    }
}
