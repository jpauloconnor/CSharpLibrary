using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //SetUp
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("What is your gamer name?");
            string gamerName = Console.ReadLine();

            Console.WriteLine("What's your player type?\n" +
                               "1: Blizen Blopper\n" +
                               "2: Troll Cat\n" +
                               "3: Horse Mange\n" +
                               "4: Soldier\n" +
                               "5: Human");


            int playerType = int.Parse(Console.ReadLine());
            Console.WriteLine(playerType);

            string typeChoice = Console.ReadLine();

            Player player = new Player(playerName, gamerName);
            player.ChooseType(playerType);


            Console.WriteLine("Your player:\n {0}",player.ToString());

            //Prompted to adventure
            Console.WriteLine("Ready for an adventure? Enter the Hidden Forest(That you found)");

            LizardDog.Speak();
            LizardDog.Attack(player);
            //Enemy class with attack points, name, and weapon


            //You go through the forest and meet a Lizard Dog
            //Create a new Lizard



            // Console.WriteLine(john.ToString());
            Console.ReadLine();
        }
    }
}
