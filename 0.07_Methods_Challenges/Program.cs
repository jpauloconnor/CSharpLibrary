﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object 1. "Use the class/cookie cutter"
            NetflixShow houseOfCards = new NetflixShow();
            houseOfCards.Name = "House of Cards";
            houseOfCards.Rating = 4.5;
            houseOfCards.Genre = "Political Drama";
            houseOfCards.shows();

            //Object 2.
            NetflixShow roseanne = new NetflixShow();
            roseanne.Name = "Roseanne";
            roseanne.Rating = 3.9;
            roseanne.Genre = "Sitcom";
            roseanne.shows();

            //Object 3.
            NetflixShow thundercats = new NetflixShow();
            thundercats.Name = "Thundercats";
            thundercats.Rating = 4.0;
            thundercats.Genre = "Cartoon/Action";
            thundercats.shows();
            thundercats.Minutes = 30;
            Console.WriteLine(thundercats.ShowMinutesLeft(15));

            thundercats.ShowWhoViewed("Ava");


            thundercats.GetSuggestion();

            List<NetflixShow> shows = new List<NetflixShow>
            {
                new NetflixShow(){ Name = "Peaky Blinders", Rating=4, Genre="Gangster" },
                new NetflixShow(){ Name = "Walking Dead", Rating=4, Genre="Horror" },
                new NetflixShow(){ Name = "Narcos", Rating=4, Genre="Gangster" }
            };


            var i = 7;
            Console.WriteLine(i);

            foreach (var show in shows)
            {
                Console.WriteLine(show.Name);
            }

            Console.ReadLine();
        }
    }
}
