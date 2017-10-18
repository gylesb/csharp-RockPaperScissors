using System.Collections.Generic;
using System;

namespace RPS.Models
{
  public class RPSchecker
  {
    public string Game(int Player1, int Player2)
    {
      if(Player1 == Player2)
      {
        return "IT'S A DRAW!";
      }
      else
      {
        return "Player 2 wins!";
      }
    }
  }
}
