using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Player john = new Player("John", "MadDog", Player.CharacterType.HorseMage);
            Console.WriteLine(john.ToString());
            Console.ReadLine();
        }
    }
}
