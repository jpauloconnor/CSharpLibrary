using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_AnonymousFunctions_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example from the Docs
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // The call to Count forces iteration of the source
            int highScoreCount = scores.Where(n => n > 80).Count();

            Console.WriteLine("{0} scores are greater than 80", highScoreCount);

            // Outputs: 4 scores are greater than 80 

            StudentClass sc = new StudentClass();
            sc.QueryHighScores(1, 90);

            Console.WriteLine("    Total By GradeLevel    ");
            sc.TotalsByGradeLevel();
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.ReadLine();


        }

    }

}
