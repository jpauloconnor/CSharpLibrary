using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._28_MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiplication Tables";
            int choice = 0;
            do
            {
                MainAppTitle();
                Console.WriteLine();
                Console.WriteLine("Select an option");
                Console.WriteLine("------------------");
                Console.WriteLine("Option 1: Addition Facts");
                Console.WriteLine("Option 2: Multiplication Facts");
                Console.WriteLine("Option 3: Quit Application");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        MainAppTitle();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Console.WriteLine("Addition Facts");
                        Console.WriteLine("----------------");
                        Console.WriteLine("You will be able to select a starting number and an ending number.");
                        Console.WriteLine("Next you will see the numbers between these selections be added");
                        Console.WriteLine("to numbers 1 - 10");
                        Console.WriteLine("");
                        Console.WriteLine("Select a starting number between 0 and 10");

                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                        }

                        finally
                        {
                            Console.WriteLine("Your start number is " + startNum);
                            Console.WriteLine("Your end number is " + endNum);
                            try
                            {
                                Console.WriteLine("Would you like more addition facts [y/n]");
                                string moreFacts = Console.ReadLine();
                                if (moreFacts == "y")
                                {
                                    continueChoice = true;
                                }
                                else
                                {
                                    continueChoice = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter y or n");
                            }
                        }

                    } while (continueChoice == true);

                }

            } while (choice != 3);
        }

        private static string MainAppTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @" _____     _ _   _     _ _         _   _            _____         _       
|     |_ _| | |_|_|___| |_|___ ___| |_|_|___ ___   |   __|___ ___| |_ ___ 
| | | | | | |  _| | . | | |  _| .'|  _| | . |   |  |   __| .'|  _|  _|_ -|
|_|_|_|___|_|_| |_|  _|_|_|___|__,|_| |_|___|_|_|  |__|  |__,|___|_| |___|";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            return appTitle;
        }
    }
}
