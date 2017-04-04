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
            Console.Title = "Math Fact Tables";
            Addition addTable = new Addition();
            Multiplication timesTable = new Multiplication();
            int choice = 0;
            do
            {
                MainAppTitle();
                choice = MainMenu();

                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        addTable.AdditionTitle();
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
                            if (startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your Addition Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                addTable.AdditionTable(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more addition facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }
                        }
                    } while (continueChoice == true);

                }

                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        MainAppTitle();
                        timesTable.MultiplicationTitle();
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
                            if (startNum > 0 && endNum <= 10)
                            {
                                timesTable.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Multiplication Table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("");
                                timesTable.MultiplicationTable(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like more multiplication facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }
                            }

                        }
                    } while (continueChoice == true);

                }

            } while (choice != 3);
        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Quit Application");
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static string MainAppTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @" _____     _   _      _____     _   _         
|     |___| |_| |_   |_   _|___| |_| |___ ___ 
| | | | .'|  _|   |    | | | .'| . | | -_|_ -|
|_|_|_|__,|_| |_|_|    |_| |__,|___|_|___|___|
                                              ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            return appTitle;
        }
    }
}