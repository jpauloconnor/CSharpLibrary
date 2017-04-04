using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._26_OOP_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAttackAnswer = null;
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

            Player player = new Player(playerName, gamerName);
            player.ChooseType(playerType);


            Console.WriteLine("Your player:\n{0}",player.ToString());

            //Prompted to adventure
            Console.WriteLine("Ready for an adventure? Enter the Hidden Forest(That you found)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You have encountered the notorious LizardDog...Fight!");
            LizardDog lizard = new LizardDog();
            lizard.Speak();
            lizard.LizardAttack(player);

            while (true)
            {
                if(player.CurrentPower > 0 && lizard.PowerLevel>0)
                {
                    Console.WriteLine("Would you like to attack? y/n");
                    userAttackAnswer = Console.ReadLine();
                }
                
                
                if (userAttackAnswer == "y" && lizard.PowerLevel > 0)
                {
                    player.Attack(lizard);
                    lizard.LizardAttack(player);
                }
                else if (player.CurrentPower <= 0)
                {
                    Console.WriteLine("You Die");
                }
                else if (userAttackAnswer == "n")
                {
                    lizard.Insult();
                    break;
                }
                else
                {
                    Console.WriteLine("Contiue on your journey");
                    break; 
                }
            }


            Console.ReadLine();
        }
    }
}
