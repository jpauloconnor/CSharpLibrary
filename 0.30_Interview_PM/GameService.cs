using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._30_Interview_PM
{
    public class GameService : IGameService
    {
        public string ReadGameSequenceFile()
        {
            string fileContents = "Read the file...";
            Console.WriteLine(fileContents);
            Console.ReadLine();
            return fileContents;
        }
        public void CheckCurrentItem()
        {
            Console.WriteLine("Check current item....");
        }
    }
}
