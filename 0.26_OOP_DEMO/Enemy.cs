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
        Random rnd = new Random();
        //my enemy is the inner me
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        protected void Attack(Player p, Dictionary<string, int> i, Object emname)
        {
            Console.WriteLine("{0} power is at {1}%", p.GamerName, p.CurrentPower);

            var singleAttack = i.ElementAt(rnd.Next(i.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            int r = rnd.Next(i.Count);
            Console.WriteLine("Here I come!");
            Console.WriteLine("{2} attacks with {0} and takes {1} damage", attackName, attackVal, emname);
            p.CurrentPower -= attackVal;
            Console.WriteLine("{0} health is now at {1}", p.GamerName, p.CurrentPower);
        }

        public void Speak()
        {
            ArrayList insult = new ArrayList { "buck-o", "grandpa", "loser", "wimp", "trash slinger", "window licker", "Mr. always on time" };
            int r = rnd.Next(insult.Count);

            Console.WriteLine("You're on the wrong side of the forest {0}", insult[r]);
        }
        
        public void Insult()
        {
            ArrayList goodbye = new ArrayList { "Yea and don't come back", "Next time fight me like a real OctoCat!", "Look whos a mommas kid!" };
        }

    }

    class LizardDog : Enemy
    {
        Dictionary<string, int> Attacks = new Dictionary<string, int> { { "Claw Slash", 10 }, { "Tail Wip", 20 }, { "Head Bash", 25 }, { "Running Man", 5 } };
        public LizardDog()
        {
            this.PowerLevel = 40;
            this.Name = "Lizard Dog";
        }

        public void LizardAttack(Player p)
        {
            if(this.PowerLevel <= 0)
            {
                
                Console.Clear();
                Console.WriteLine("{0} you have conquored the {1}", p.GamerName, this.Name);
            }
            else
            {
                Attack(p, Attacks, this.Name);
            }
        }
    }
}
