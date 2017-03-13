using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects_Challenges
{
    public class Hotel
    {
        public string RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int NumRooms { get; set; }

        public void PrintNumber()
        {
            Console.WriteLine("Hello, your room number is {0}", RoomNumber);
            Console.ReadLine();
        }

    }
}
