using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_Demo_Paul
{
    class Creature
    {

        //PROPERTIES
        public int Power { get; set; }

        //METHODS
        public void AnnounceFight(string gamerName)
        {
            Console.WriteLine("Hello," + gamerName + "I am the Lizard Man of Gond. I hope you're ready to fight. I will destroy you.");
        }
        public void CallCoward()
        {
            Console.WriteLine("You are weak! You can't win.");
        }
        public void DidNotGet()
        {
            Console.WriteLine("We did not get that.");
        }

        public int GetPowerLevel()
        {
            Random rando = new Random();
            int power = rando.Next(1, 100);
            this.Power = power;
            return Power;
        }

        public void AnnouncePower()
        {
            Console.WriteLine("My power is {0}. What is yours?", this.Power);
        }

        public void Speak()
        {
            ArrayList insult = new ArrayList { "buck-o", "grandpa", "loser", "wimp", "trash slinger", "window licker", "Mr. always on time" };
            Random rnd = new Random();
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }

        public void Attack(Player p)
        {
            Dictionary<string, int> Attacks = new Dictionary<string, int> { { "Claw Slash", 10 }, { "Tail Wip", 20 }, { "Head Bash", 30 }, { "Running Man", 40 } };
            Random rnd = new Random();
            var singleAttack = Attacks.ElementAt(rnd.Next(Attacks.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            int r = rnd.Next(Attacks.Count);
            Console.WriteLine("Here I come!");
            Console.WriteLine("LizardDog attacks with {0} and takes {1} damage", attackName, attackVal);
            p.CurrentPower -= attackVal;
            Console.WriteLine("{0} health is now at {1}", p.GamerName, p.CurrentPower);
        }


    }
}
