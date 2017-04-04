using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._26_OOP_Demo_Paul
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //SetUp
            Console.WriteLine("What is your name, soldier?");
            string playerName = Console.ReadLine();

            Console.WriteLine("What is your gamer name, or your epithet?");
            string gamerName = Console.ReadLine();

            Console.WriteLine("What's your player type?\n" +
                               "1: The JS Wizard\n" +
                               "2: Troll Cat\n" +
                               "3: Horse Mange\n" +
                               "4: Soldier\n" +
                               "5: Human");

            int playerType = int.Parse(Console.ReadLine());
            
            Player player = new Player(playerName, gamerName);
            player.ChooseType(playerType);

            Console.WriteLine("Welcome:\n {0}", player.ToString());
            //Pick a weapon
            Console.WriteLine("What's your weapon?\n" +
                               "1: The Sword of Smigel\n" +
                               "2: The Axe of Evermore\n" +
                               "3: The Ring of Valkrow\n" +
                               "4: The Laser of Lambeaux\n" +
                               "5: The Dusty Stick");


            //TODO: Make a weapon enum.
            int weaponType = int.Parse(Console.ReadLine());

            //Go to battle
            Console.WriteLine("Would you like to go to battle now? Type yes or no.");
            string response = Console.ReadLine();

            Creature lizard = new Creature();
            //Doing Battle
            if (response == "yes")
            {
                lizard.AnnounceFight(playerName);
            }
            else
            { 
                lizard.CallCoward();
            }

            //FOE'S POWER LEVEL
            lizard.GetPowerLevel();
            lizard.AnnouncePower();


            // the thread is paused for 5000 milliseconds
         
        while (player.CurrentPower > 0 || lizard.CreaturePower > 0)
            {
                lizard.Speak();
                lizard.Attack(player);

                int sleepfor = 5000;
       
                Thread.Sleep(sleepfor);
                Console.WriteLine("****************");

                player.Attack(lizard);

                Thread.Sleep(sleepfor);
                Console.WriteLine("****************");
                Console.Clear();

            }

            lizard.Speak();
            lizard.Attack(player);
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
