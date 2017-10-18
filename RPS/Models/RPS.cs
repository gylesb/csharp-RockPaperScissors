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
      else if(Player1 == 1 && Player2 == 3)
      {
        return "Player 1 wins!";
      }
      else if(Player1 == 2 && Player2 == 1)
      {
        return "Player 1 wins!";
      }
      else if(Player1 == 3 && Player2 == 2)
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
