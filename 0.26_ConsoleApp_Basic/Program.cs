using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26_ConsoleApp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Intro story = new Intro();
            story.InterviewUser();

            //Might be nice to show how you can refactor all of this inot class/method    
            /*
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if (age < 21)
            {
                Console.WriteLine("Well, you want me able to go to the bar. Sorry.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hey, should we go to the bar after work?");
                Console.ReadLine();
            }
            */

        }
    }
}
