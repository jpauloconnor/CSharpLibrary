using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_Inheritance
{
    public class Bear : Animal
    {

        //PROPERTIES
        public bool hibernate { get; set; }
        public bool stealsPicnicBaskets { get; set; }
        public int numberOfSalmonPerDay { get; set; }
        public string temperatureOfPorridge { get; set; } //Hot cold just right

        //METHODS
        public override void StateType()
        {  //Discuss how the virtual keyword allows us to do this.
            Console.WriteLine("I am a bear");
        }

        public void EatHiker()
        {
            Console.WriteLine("I just ate a hiker.");
        }

        public override void GetMad()
        {
            Console.WriteLine("Hello, I'm a big bad bear.");
        }
    }
}

