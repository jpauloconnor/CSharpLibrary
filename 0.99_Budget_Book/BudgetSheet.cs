using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_Budget_Book
{
    //1
    class BudgetSheet
    {
        //9 Create a constructor
        public BudgetSheet()
        {
            //add ctor syntax for initializing deposits
            //12 deposits is private
            deposits = new List<decimal>();
        }
   
        //2
        public void DepositMoney(decimal money)
        {
            //4
            deposits.Add(money);
        }
        //3
        //List<decimal> deposits;

        //6
        //Field initializer syntax
        // List<decimal> deposits = new List<decimal>();
        //10
        List<decimal> deposits;

        //15 Return a type class with a method.
        public BudgetActivity ShowAccountActivity()
        {
            //15 return new BudgetActivity();
            //16 object
            BudgetActivity activity = new BudgetActivity();
            //17 set up some activity
            decimal balance = 0;
            foreach(decimal deposit in deposits)
            {
                //21 - Keep track of highest and lowest
                activity.High = Math.Max(deposit, activity.High);
                activity.Low = Math.Max(deposit, activity.High);

                //22 -back to program

                balance += deposit;
            }

            //19 Get the average
            activity.Average = balance / deposits.Count;
            
            return activity;
        }

    }
}
