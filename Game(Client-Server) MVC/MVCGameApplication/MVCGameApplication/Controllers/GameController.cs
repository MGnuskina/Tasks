using GameServer;
using MVCGameApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGameApplication.Controllers
{
    public class GameController : Controller
    {
        GameApplication game;
        // GET: Game
        [HttpGet]
        public ActionResult Index(GameRequestViewModel request)
        {
            game = GameApplication.Instance;
            GameViewModel model = new GameViewModel();
            List<int[]> pointsFrom = new List<int[]>();
            List<int[]> pointsTo = new List<int[]>();
            int drawSize;
            model.clickedPointY = 0;
            model.clickedPointX = 0;
            game.CreateGame(request.GameName, 800, 800, out pointsFrom, out pointsTo, out drawSize);//width, height!!!!!
            model.drawSize = drawSize;
            model.pointFrom = pointsFrom;
            model.pointsTo = pointsTo;
            model.Title = request.GameName;
            model.User = new CurrentUser() { Name = request.UserName, Password = request.UserPassword };
            model.Game = game;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(GameViewModel model)
        {
            //game.PlayersMove()
            return View(model);
        }

        [HttpPost]
        public ActionResult Move(GameViewModel model)
        {

            return View(model);
        }
    }
}