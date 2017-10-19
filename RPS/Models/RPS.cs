using System.Collections.Generic;
using System;

namespace RPS.Models
{
  public class RPSchecker
  {
    private string _player1name;
    private string _player2name;
    private string _player1value;
    private string _player2value;

    private static RPSchecker _checker = null;

    public void Save()
    {
      _checker = this;
    }

    public static RPSchecker GetChecker()
    {
      return _checker;
    }

    public string GetP1Name()
    {
      return _player1name;
    }
    public string GetP2Name()
    {
      return _player2name;
    }
    public void SetP1Name(string newName)
    {
      _player1name = newName;
    }
    public void SetP2Name(string newName)
    {
      _player2name = newName;
    }
    public string GetP1Value()
    {
      return _player1value;
    }
    public string GetP2Value()
    {
      return _player2value;
    }
    public void SetP1Value(string newValue1)
    {
      _player1value = newValue1;
    }
    public void SetP2Value(string newValue2)
    {
      _player2value = newValue2;
    }


    public string Game(string newValue1, string newValue2)
    {
      if(newValue1 == newValue2)
      {
        return "IT'S A DRAW!";
      }
      else if(newValue1 == "1" && newValue2 == "3")
      {
        return "Player 1 wins!";
      }
      else if(newValue1 == "2" && newValue2 == "1")
      {
        return "Player 1 wins!";
      }
      else if(newValue1 == "3" && newValue2 == "2")
      {
        return "Player 1 wins!";
      }
      else
      {
        return "Player 2 wins!";
      }
    }
  }
}
