using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel penthouseSuite = new Hotel();
            penthouseSuite.IsAvailable = false;
            penthouseSuite.RoomNumber = "a23";
            penthouseSuite.NumRooms = 3;
            penthouseSuite.PrintNumber();
            penthouseSuite.CheckAvailability();

            Console.ReadLine();
        }
    }
}
