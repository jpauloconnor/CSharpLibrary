using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._30_Interview_PM
{
    public class GameController
    {
        private static GameService game = new GameService();

        public static void Start()
        {
            game.ReadGameSequenceFile();
            game.CheckCurrentItem();
        }
    }
}
