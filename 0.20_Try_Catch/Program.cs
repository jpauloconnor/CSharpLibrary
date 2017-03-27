﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Age ageObjectVariableName = new Age();
            try
            {
                ageObjectVariableName.showAge();
            }
            catch (AgeException exception)
            {
                Console.WriteLine("TempIsZeroException: {0}", exception.Message);
            }
            Console.ReadKey();

        }
    }
}
