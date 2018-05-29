using System;
using _0._25_LINQ_QuerySyntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _0._25_LINQ_QuerySyntax_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindExistingPlayer()
        {
            //<-- Arrange
            PlayerRepository repository = new PlayerRepository();
            var playerList = repository.Retrieve();

            //<-- Act
            var result = repository.Find(playerList, 2);

            //<-- Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.PlayerID);
            Assert.AreEqual("Lebron James", result.Name);
            Assert.AreEqual(23, result.Number);
            Assert.AreEqual(29.5m, result.PointsPerGame);
        }

        [TestMethod]
        public void PlayerDoesNotExist()
        {
            //<-- Arrange
            PlayerRepository repository = new PlayerRepository();
            var playerList = repository.Retrieve();

            //<-- Act
            var result = repository.Find(playerList, 52);

            //<-- Assert
            Assert.IsNull(result);
        }
    }
}
