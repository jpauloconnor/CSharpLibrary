using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Exceptions_Try_Catch
{
    class NumberGenerator
    {
        int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int GetNumber(int index)
        {
            if (index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException();
            }
            Console.WriteLine(index);
            Console.ReadLine();
            return numbers[index];
        }
    }
}
