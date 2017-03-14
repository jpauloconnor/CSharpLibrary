using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Weekday day = Weekday.Wednesday;

            switch (day)
            {
                case Weekday.Monday:
                    Console.WriteLine("Somebody's got a case of the Mondays!");
                    break;
                case Weekday.Tuesday:
                case Weekday.Wednesday:
                    Console.WriteLine("Hump Day");
                    break;
                case Weekday.Thursday:
                case Weekday.Friday:
                    Console.WriteLine("Gots to work.");
                    break;
                default:
                    Console.WriteLine("Hang out with kids, and maybe mow the lawn.");
                    break;
            }

        }
    }



    // enums - custom types. 
    enum Weekday
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    };



}
