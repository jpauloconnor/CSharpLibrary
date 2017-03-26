using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_Budget_Book
{
    class Program
    {
        static void Main(string[] args)
        {
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



            Console.ReadLine();
        }
    }
}
