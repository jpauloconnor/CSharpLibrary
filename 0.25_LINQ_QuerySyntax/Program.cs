using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_LINQ_QuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerRepository repository = new PlayerRepository();
            var playerList = repository.Retrieve();

            var result = repository.Find(playerList, 3);

            Console.WriteLine(result.Name);
            Console.ReadLine();
        }
    }
}
