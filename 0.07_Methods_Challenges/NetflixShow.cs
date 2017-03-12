using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Challenges
{
    class NetflixShow
    {
        //Properties
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Genre { get; set; }

        //Methods
        public void shows()
        {
            Console.WriteLine("Name: {0}  Genre: {1}  Rating: {2}", Name, Genre, Rating);
        }

        public string GetSuggestion()
        {
            if (this.Rating >= 4)
                return "You definitely need to watch this show";
            else
                return "You probably won't want to watch this show";
        }
    }
}
