using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPStest
  {

    [TestMethod]
    public void ComparePlayers_CompareValues1_True()
    {
      //Arrange
      RPSchecker newValue = new RPSchecker();

      //Action
      var result = newValue.Game(1, 1);
      var expected = "IT'S A DRAW!";

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ComparePlayers_CompareValues2_True()
    {
      //Arrange
      RPSchecker newValue = new RPSchecker();

      //Action
      var result = newValue.Game(1, 3);
      var expected = "Player 1 wins!";

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ComparePlayers_CompareValues3_True()
    {
      //Arrange
      RPSchecker newValue = new RPSchecker();

      //Action
      var result = newValue.Game(2, 1);
      var expected = "Player 1 wins!";

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ComparePlayers_CompareValues4_True()
    {
      //Arrange
      RPSchecker newValue = new RPSchecker();

      //Action
      var result = newValue.Game(3, 2);
      var expected = "Player 1 wins!";

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void ComparePlayers_CompareValues5_True()
    {
      //Arrange
      RPSchecker newValue = new RPSchecker();

      //Action
      var result = newValue.Game(2, 3);
      var expected = "Player 2 wins!";

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
