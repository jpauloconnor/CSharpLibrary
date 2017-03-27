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
            Console.WriteLine("What is your name?");

             //Player player = new Player("", "", Player.CharacterType.HorseMage);
            Player player = new Player();
            player.PlayerName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            player.GamerName = Console.ReadLine();
            Console.WriteLine("What kind of character would you like to be?");
            Console.WriteLine("Which type would you like to be?");

            string typeChoice = Console.ReadLine();
//var type = player.ReturnType("HorseMage");
            // type = Console.ReadLine();



            Console.WriteLine(player.DeclareType());

            Console.WriteLine(player.ToString());



           // Console.WriteLine(john.ToString());
            Console.ReadLine();
        }
    }
}
