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
        public int Minutes { get; set; }

        //Methods
        public void shows()
        {
            Console.WriteLine("Name: {0}  Genre: {1}  Rating: {2}", Name, Genre, Rating);
        }

        public void GetSuggestion()
        {
            if (this.Rating >= 3.5)
                Console.WriteLine("You definitely need to watch this show");
            else
                Console.WriteLine("You probably won't want to watch this show");
        }

        public string PayBill()
        {
            return "Your monthly bill is ...";
        }

        public int ShowTotalMinutes()
        {
            return Minutes;
        }

       public string ShowWhoViewed(string user)
        {
            Console.WriteLine(user);
            return user;
        }


        public int ShowMinutesLeft(int minutesWatched)
        {
            int minutesLeft = Minutes - minutesWatched;
            return minutesLeft;
        }




    }
}


/*
BRONZE: Create a Netflix class with Properties of Name, Genre, Rating. Create three objects from that class.

SILVER: Create a method called GetSuggestion() that returns different messages if 
the Rating is over 4 to the console that says, "You should definitely watch 
this show." The else message could be "You probably won't want to watch this show".

GOLD: Create a list of objects based on the Netflix class.
Write a foreach loop that would iterate over the loop and print
the name, genre, and rating of each object.
*/
