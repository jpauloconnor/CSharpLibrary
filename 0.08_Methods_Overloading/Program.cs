using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Player playerOne = new Player();
            playerOne.Attack();
            playerOne.Attack(5);
            playerOne.Attack(500, "Laser");
            Console.ReadLine();
        }
    }
}
