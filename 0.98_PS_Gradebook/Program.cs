using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._98_PS_Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook();
            book.AddGrade(81);
            book.AddGrade(91.5f);

            book = new Gradebook();
            book.AddGrade(75);
          
        }
    }
}
