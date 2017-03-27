using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_OOP_DEMO
{
    abstract class Enemy
    {
        //my enemy is the inner me
        protected string Name { get; set; }
        protected int PowerLevel { get; set; }

        protected virtual void Attack(Player p)
        {
            p.CurrentPower -= 5;
            Console.WriteLine("{0} power is at {1}%", p.GamerName, p.CurrentPower);
        }
    }

    class LizardDog : Enemy
    {
        

        public static void Speak()
        {
            ArrayList insult = new ArrayList { "buck-o" , "grandpa", "loser", "wimp", "trash slinger","window licker", "Mr. always on time" };
            Random rnd = new Random();
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }

        public static new void Attack(Player p)
        {
            Dictionary<string, int> Attacks = new Dictionary<string, int> { { "Claw Slash", 10 }, { "Tail Wip", 20 } , { "Head Bash", 30 }, { "Running Man", 40 }};
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
