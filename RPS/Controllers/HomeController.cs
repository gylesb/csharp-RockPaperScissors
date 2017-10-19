using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RPS.Models;
using System;

namespace RPS.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/player1")]
    public ActionResult Player1()
    {
      RPSchecker newPlayer = new RPSchecker();
      newPlayer.SetP1Name(Request.Form["player1Name"]);
      newPlayer.SetP2Name(Request.Form["player2Name"]);

      return View();
    }

    [HttpPost("/player2")]
    public ActionResult Player2()
    {
      RPSchecker newPlayerVal = new RPSchecker();
      newPlayerVal.SetP1Value(Request.Form["player1Val"]);

      return View();
    }

    [HttpPost("/result")]
    public ActionResult Result()
    {
      RPSchecker newPlayerVal = new RPSchecker();
      newPlayerVal.SetP2Value(Request.Form["player2Val"]);

      RPSchecker newP1Collect = new RPSchecker();
      var collectP1 = newP1Collect.GetP1Value();
      RPSchecker newP2Collect = new RPSchecker();
      var collectP2 = newP2Collect.GetP2Value();


      RPSchecker winner = new RPSchecker();
      winner.Game(collectP1, collectP2);

      return View();
    }

    // [HttpPost("/result")]
    // public ActionResult Result()
    // {
    //   // newGame = new Game (Request.Form["player2"])
    //   Request.Form["player2"];
    //   return View();
    // }
  }
}
