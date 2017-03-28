using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._26_OOP_Game_Official
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

            Console.WriteLine("" +
               "" +
               "" +
               "" +
               "");

        
            Console.WriteLine("Welcome:\n {0}", player.ToString());
            //Pick a weapon
            Console.WriteLine("What's your weapon?\n" +
                               "1: The Sword of Smigel\n" +
                               "2: The Axe of Evermore\n" +
                               "3: The Ring of Valkrow\n" +
                               "4: The Laser of Lambeaux\n" +
                               "5: The Dusty Stick");

            int weaponType = int.Parse(Console.ReadLine());

            //Go to battle
            Console.WriteLine("Would you like to go to battle now? Type yes or no.");
            string response = Console.ReadLine();

            Creature creature = new Creature();
            creature.CreatureName = "Lizard Dog";
            //Doing Battle
            if (response == "yes")
            {
                creature.AnnounceFight(playerName);
                RunThread(5000);
            }
            else
            {
                creature.CallCoward();
            }

            //ESTABLISH CREATURE'S POWER LEVEL
            creature.GetPowerLevel();
            creature.AnnouncePower();


            //BATTLE SEQUENCE
            while (player.CurrentPower > 0 || creature.CreaturePower > 0)
            {
                creature.Speak();
                creature.Attack(player);
                player.Speak();
                player.Attack(creature);
                RunThread(5000);

                if(creature.CurrentPower <= 0)
                {
                    Console.WriteLine(player.GamerName + " Wins!"); 
                }
                if(player.CurrentPower <= 0)
                {
                    Console.WriteLine(creature.CreatureName + " wins!");
                }
            }

            Console.ReadLine();

            //Meet Bubble Creature
            //Win or lose the game

        }

        public static void RunThread(int pauseTime)
        {
            int sleepFor = pauseTime;
            Thread.Sleep(sleepFor);
            Console.WriteLine("                 ");
        }

    }
}
