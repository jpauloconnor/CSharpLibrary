using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Dictionaries_Challenges
{
    public class Program
    {
        public static void Main()
        {

            /*********BRONZE*********/
            Dictionary<string, string> bestPicture = new Dictionary<string, string>()
    {
        {"2000", "American Beauty"},
        {"2001", "Gladiator"},
        {"2002", "Beautiful Mind"},
        {"2003", "Chicago"},
        {"2004", "Lord of the Rings: The Return of the King"},
        {"2005", "Million Dollar Baby"}

    };

            // Loop over pairs with foreach.
            foreach (KeyValuePair<string, string> pair in bestPicture)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }


            Console.WriteLine("                                                ");
            Console.WriteLine("                                                ");

            /*********SILVER*********/




            var bestPictureNominees = new Dictionary<string, string[]>()
        {
            {"2000", new string[] {"Movie1", "Movie2", "Movie3"}},
            {"2001", new string[] {"Movasdf", "Movie2", "Movie3"}},
            {"2002", new string[] {"Movasdfa", "Movie2", "Movie3"}},

        };


            foreach (KeyValuePair<string, string[]> pair in bestPictureNominees)
            {
                Console.WriteLine("{0}, {1}, {2}", pair.Key, pair.Value[0], pair.Value[1]);

            }


            Console.WriteLine("                                                ");
            Console.WriteLine("                                                ");

            /*********GOLD*********/
            Console.WriteLine("Please type a year to show the movie that won: ");
            string readLine = Console.ReadLine();

            if (bestPicture.ContainsKey(readLine))
            {
                string value_For_Key = bestPicture[readLine];
                Console.WriteLine("The best picture in " + readLine + " was " + value_For_Key);
            }

            Console.WriteLine("Please type a year to show the movies that were up for an award that year: ");
            string readLineTwo = Console.ReadLine();

            if (bestPictureNominees.ContainsKey(readLine))
            {

                string[] value_For_Key = bestPictureNominees[readLine];
                string s = string.Join(", ", value_For_Key);
                Console.WriteLine("The best nominees in " + readLine + " were " + s);
            }
        }

    }
}
