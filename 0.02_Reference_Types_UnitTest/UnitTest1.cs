using System;
using _0._02_Reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _0._02_Reference_Types_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Music a = new Music() { Band = "Beatles", SongName = "Yesterday", YearReleased = 1965 };
            Music b = new Music();

        }
    }
}
