using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._32_FileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\MyTest.txt";
            string dirPath = @"c:\temp\";
            CustomFileReading cf = new CustomFileReading();
            cf.CreateFile(path);

            cf.CopyFile(@"c:\temp\");
            Console.ReadLine();
        }
    }
}
