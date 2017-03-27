using System;
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
            Console.WriteLine(this.Power);
            return Power;
        }

        public void AnnouncePower()
        {
            Console.WriteLine("My power is {0}. What is yours?", this.Power);
        }

    }
}
