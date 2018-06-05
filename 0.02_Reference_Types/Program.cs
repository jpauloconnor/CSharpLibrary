using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Are these two the same?
            Music a = new Music() { Band = "Beatles", SongName = "Yesterday", YearReleased = 1965 };
            Music b = new Music() { Band = "Beatles", SongName = "Yesterday", YearReleased = 1965 };



        }
    }

}
