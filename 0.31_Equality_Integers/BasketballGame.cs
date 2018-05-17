using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31_Equality_Integers
{
    class BasketballGame
    {
        public static int GetScore()
        {
            Console.WriteLine("What is the score of the game?");
            string score = Console.ReadLine();
            int scoreInt = Int32.Parse("score");
            return scoreInt;
        }

        public static bool CheckWhetherScoreMatchesMyVegasScore(int myVegasScore, int gameScore)
        {
            bool playerWin;
            if (myVegasScore == gameScore)
                playerWin = true;
            else
                playerWin = false;
            return playerWin;
        }



    }
}
