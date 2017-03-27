using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_Budget_Book
{
    class Program
    {
        static void Main(string[] args)
        {

            //23 Go to bin/debug on cmd and show how you can run the program

            //24 Right click on References
            //Add reference - dig down into the Object Explorer
            //Choose Speech()
            //Choose ctrl .
            SpeechSynthesizer speak = new SpeechSynthesizer();
           // speak.Speak("Hey, you are rich!");

            //5
            BudgetSheet sheet = new BudgetSheet();
            sheet.DepositMoney(120.0M);
            sheet.DepositMoney(1000.0M);
            sheet.DepositMoney(800.0M);

            //8 set a break point

            //11 Talk about reference types & pointers.
            //BudgetSheet sheet2 = sheet; 

            //22 Activity
            BudgetActivity activity = sheet.ShowAccountActivity();
            Console.WriteLine(activity.Average);
            Console.WriteLine(activity.High);
            Console.WriteLine(activity.Low);

            ShowBudget("Average", activity.Average);
            ShowBudgetAgain("Average", activity.Average);

            if(activity.Average < 800)
            {
                speak.Speak("Alert your account is looking low");
            }
            
            Console.ReadLine();
           
        }

        //30 overloads
        public static void ShowBudget(string type, decimal result)
        {
            Console.WriteLine(type + " : " + result);
        }

        public static void ShowBudgetAgain(string interpString, decimal result)
        {
            //Console.WriteLine("{0}: {1:C}", interpString, result);
            Console.WriteLine($"{interpString}: {result:C}", interpString, result);

        }
    }
}
