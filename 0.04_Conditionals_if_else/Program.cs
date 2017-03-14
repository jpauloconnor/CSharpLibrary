using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use else to give JS an alternative statement to execute

            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreOnIt = true;
            int elevatorNumber = 13;

            //7
            if (elevatorUp == true)
            {    //Note: You don't have to have the ===
                Console.WriteLine("Going up");
            }
            else
            {
                Console.WriteLine("Going down");
            }

            //Write one for elevator broken:
            if (elevatorBroken)
            {    //Note: You don't have to have the ===
                Console.WriteLine("Bummer. Let's take the stairs.");
            }
            else
            {
                Console.WriteLine("Which floor?");
            }

            //Write another one for stuck:
            if (elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Oh no! We're stuck!");
            }
            else
            {
                Console.WriteLine("This elevator is fast.");
            }

            //But maybe we're standing there waiting?
            if (elevatorBroken && elevatorDown)
            {
                Console.WriteLine("I hope this thing doesn't start flying down!");
            }
            else
            {
                Console.WriteLine("How long are you in town for?");
            }

            if (elevatorBroken || elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Hi Bob, this is Bob with maintenance. How can I help?");
            }

            //Using ints and other types
            if (elevatorNumber == 13 && elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("This is not our lucky day!");
            }

            Console.ReadLine();
        }
    }
}
