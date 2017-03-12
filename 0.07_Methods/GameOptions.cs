using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Clean this up.
namespace _0._07_Methods
{
    class GameOptions
    {
        //wouldn't normally do this, but for demo
        public string playerName;
        public int currentScore;

        public void ShowName()
        {
            Console.WriteLine("Hello, Player 1");
        }

        public string ReturnPlayerName()
        {
            return playerName;
        }

        public string SetScore(int score)
        {
            string scoreMessage = "your score is" + score;
            return scoreMessage;
        }
    }
}
