using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_Console_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changing Console Tittle
            // Console.Title = "Stuff";

            //GetExecuting Assembly
            Console.Title = Assembly.GetExecutingAssembly().GetName().FullName;

            //Challenge find the 
            Console.SetWindowSize(20, 20);

            //Don't want scroll size to be same size as window size
            //Cursor goes to next line.
            Console.SetBufferSize(20, 20);

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear(); //fixes bg color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Static methods
            WriteWarning("This is a warning");
            //WriteError("This is an error");
            
            string input;

            do
            {
                Console.WriteLine("Enter something below. Type 'end' to end the program");
                input = Console.ReadLine();
                Console.WriteLine("We agree, " + input + " to you too.");
            } while (input != "end");
            /*
            do
            {
                var key = Console.ReadKey(true);
                Console.WriteLine(key.KeyChar);

                switch (key.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("You pressed A");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("You pressed A");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("You pressed A");
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("You pressed A");
                        break;
                }
            } while (true);
            */

            ///Reading from a file
            /*
            var inputFile = Path.Combine(Environment.CurrentDirectory, "students.txt");
            var studentNames = new StreamReader(inputFile);

            Console.SetIn(studentNames);

            string currName = Console.ReadLine();
            while (currName != null)
            {
                Console.WriteLine("Read from file:" + currName);

                currName = Console.ReadLine();
            }

            Console.Write("Press enter to continue.");

            Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            Console.ReadLine();
            */

        }

        static void WriteWarning(string warning)
        {
            var origColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(warning);

            Console.ForegroundColor = origColor;

        }
    }
}
