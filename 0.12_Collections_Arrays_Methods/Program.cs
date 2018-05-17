using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Arrays_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //.Copy - notice that it is a static method called directly on the Array class...
            string[] coolBands = { "Radiohead", "Flying Lotus", "Herbie Hancock" };
            string[] coolBandsCopy = new string[3];

            Console.WriteLine(coolBands.Reverse());

            Array.Copy(coolBands, coolBandsCopy, 3);
            foreach(var band in coolBandsCopy)
            {
                Console.WriteLine("Here are the bands: {0}", band);
            }

            Console.WriteLine("BinarySearch:{0}", Array.BinarySearch(coolBands, "Radiohead"));

            Console.ReadLine();
        }
    }
}
