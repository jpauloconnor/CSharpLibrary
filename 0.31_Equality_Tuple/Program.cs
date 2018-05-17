using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31_Equality_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> ageAndBirthYear = Tuple.Create(41, 1976);
            Tuple<int, int> ageAndBirthYearWife = Tuple.Create(41, 1976);

            Console.WriteLine("Method:{0}", ageAndBirthYear.Equals(ageAndBirthYearWife));
        }
    }
}
