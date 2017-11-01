using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_Game_OOP_Jay
{
    class Player : Character
    {
        //Constructors
        public Player(string name, Specialization spec)
        {
            this.Name = name;
            this.Role = spec;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;

        }

        //Properties
        public Specialization Role { get; set; }
        public string Name { get; set; }

        //Enums
        public enum Specialization
        {
            HorseMange,
            TrollCat,
            KnightTemplator,
            Demogorg,
            Vampire,
            BovineFrog
        }
        public enum Action
        {
            Attack,
            Run,
            Hide
        }
    }
}
