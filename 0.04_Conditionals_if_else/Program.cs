using System;

namespace _0._04_Conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreOnIt = true;
            int elevatorNumber = 13;

            if (elevatorUp == true)
            {    
                Console.WriteLine("Going up");
            }
            else
            {
                Console.WriteLine("Going down");
            }

            //Write one for elevator broken:
            if (elevatorBroken)
            {    
                Console.WriteLine("Bummer. Let's take the stairs.");
            }
            else
            {
                Console.WriteLine("Which floor?");
            }

            if (elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("Oh no! We're stuck!");
            }
            else
            {
                Console.WriteLine("This elevator is fast.");
            }

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

            if (elevatorNumber == 13 && elevatorStuckWhileWeAreOnIt)
            {
                Console.WriteLine("This is not our lucky day!");
            }

            Console.ReadLine();
        }
    }
}
