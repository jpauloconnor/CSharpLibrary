using System;
using _0._01_Intro;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _0._01_Intro_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrintAnythingToConsoleMethod()
        {
            //-- Arrange
            HelloWorld helloWorld = new HelloWorld();
            var test = "Test String";

            //-- Act
            string actual = helloWorld.PrintAnythingToConsole(test);

            //-- Assert
            Assert.AreEqual(test, actual);
        }
    }
}
