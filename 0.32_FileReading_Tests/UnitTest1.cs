using System;
using _0._32_FileReading;
using _0._32_FileReading_Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _0._32_FileReading_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFileExistsMethod()
        {
            //---> Arrange
            string path = @"c:\temp\MyTest.txt";
            var cf = new CustomFileReading();

            //---> Act
            bool fileExistsCheck = cf.FileExists(path);

            //---> Assert
            Assert.IsTrue(!fileExistsCheck);
        }

        [TestMethod]
        public void TestCreateFileMethod()
        {
            //---> Arrange
            string path = @"c:\temp\MyTest.txt";
            var cf = new CustomFileReading();

            //---> Act
            string filePath = cf.CreateFile(path);

            //---> Assert
            Assert.AreEqual(path, filePath);
        }
    }
}
