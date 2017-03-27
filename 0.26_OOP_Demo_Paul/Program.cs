using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_Demo_Paul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name Character
            Console.WriteLine("What is your name, warrior?");
            Player player = new Player();
            player.PlayerName = Console.ReadLine();
            string playerName = player.PlayerName.ToString();

            Console.WriteLine("What is your game name?");
            player.GamerName = Console.ReadLine();
            string gamerName = player.GamerName.ToString();

            //Pick a character type
            Console.WriteLine("What kind of character would you like to be? Choose  BlitzenBlopper, TrollCat, HorseMage?");
            // player.Type = Console.ReadLine();
            var characterType = Console.ReadLine();
            characterType = player.Type.ToString();
            Console.WriteLine(characterType);

            //Pick a weapon
            Console.WriteLine("What is the name of your sword?");
            var weapon = Console.ReadLine();

            //Go to battle
            Console.WriteLine("Would you like to go to battle now? Type yes or no.");
            

            //Put this in a function....
            string response = Console.ReadLine();

            //  CREATE A FOE
            Creature lizard = new Creature();

            //Doing Battle
            if (response == "yes")
            {
                lizard.AnnounceFight(playerName);
            }
            else if(response == "no")
            { 
                lizard.CallCoward();
            }
            else
            {
                lizard.DidNotGet();
            }

            //FOE'S POWER LEVEL
            lizard.GetPowerLevel();
            lizard.AnnouncePower();
            player.DeclareType();
            response = Console.ReadLine();
            if (response == "yes")
                player.Attack();
            else
                player.AnotherDay();

            Console.ReadLine();
           
            //Meet Bubble Creature
            //Win or lose the game



        }
    }
}
