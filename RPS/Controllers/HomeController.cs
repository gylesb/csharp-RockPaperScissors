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
      newPlayer.Save();
      return View();
    }

    [HttpPost("/player2")]
    public ActionResult Player2()
    {
      RPSchecker newPlayerVal = RPSchecker.GetChecker();
      newPlayerVal.SetP1Value(Request.Form["player1Val"]);
      return View();
    }

    [HttpPost("/result")]
    public ActionResult Result()
    {
      RPSchecker newPlayerVal = RPSchecker.GetChecker();
      newPlayerVal.SetP2Value(Request.Form["player2Val"]);
      return View(newPlayerVal);
    }
  }
}
