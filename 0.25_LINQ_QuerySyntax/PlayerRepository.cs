using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25_LINQ_QuerySyntax
{
    public class PlayerRepository
    {
        public Player Find(List<Player> playerList, int playerId)
        {
            Player foundPlayer = null;

            foundPlayer = playerList.FirstOrDefault(p => p.PlayerID == playerId);
            //foreach (var p in playerList)
            //{
            //    if (p.PlayerID == playerId)
            //    {
            //        foundPlayer = p;
            //        break;
            //    }
            //}

            return foundPlayer;
        }

        public List<Player> Retrieve()
        {
            List<Player> playerList = new List<Player>
            {
                new Player()
                {
                    PlayerID = 1,
                    Name = "Steph Curry",
                    Number = 31,
                    PointsPerGame = 29.7m
                },
                new Player()
                {
                    PlayerID = 2,
                    Name = "Lebron James",
                    Number = 23,
                    PointsPerGame = 29.5m
                },
                new Player()
                {
                    PlayerID = 3,
                    Name = "Kevin Durant",
                    Number = 35,
                    PointsPerGame = 29.5m
                }
            };
            return playerList;
        }
    }
}
