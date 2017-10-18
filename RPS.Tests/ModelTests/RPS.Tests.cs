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
  }
}
