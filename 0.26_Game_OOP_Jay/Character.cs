using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_Game_OOP_Jay
{
    public abstract class Character
    {
        //Constants
        const int Min_Health = 0;

        //Properties
        public bool IsAlive { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Energy { get; set; }
        public double CritChance { get; set; }

        //Methods
        public double Attack()
        {
            Random rnd = new Random();
            int spread = rnd.Next(-3, 3);
            double damage = this.AttackPower + spread;
            bool isCrit = IsCritical();
            return isCrit ? (damage * 2) : damage;
        }

        public bool IsCritical()
        {
            Random rnd = new Random();
            bool isCrit = rnd.Next(0, 100) < (this.CritChance * 100) ? true : false;
            return isCrit;
        }
    }
}
