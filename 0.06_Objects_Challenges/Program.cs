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
            Hotel a23 = new Hotel();
            a23.IsAvailable = false;
            a23.RoomNumber = "a23";
            a23.NumRooms = 3;
            a23.PrintNumber();
            a23.CheckAvailability();

            Console.ReadLine();
        }
    }
}
