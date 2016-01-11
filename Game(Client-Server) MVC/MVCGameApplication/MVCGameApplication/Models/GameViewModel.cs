using GameServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGameApplication.Models
{
    public class GameViewModel
    {
        public List<int[]> pointFrom { get; set; }
        public List<string> objToDraw { get; set; }
        public bool gameIsFinished { get; set; }
        public bool currentPlayerIsWinner { get; set; }
        public string Title { get; set; }
        public List<int[]> pointsTo { get; set; }
        public int drawSize { get; set; }
        public int clickedPointX { get; set; }
        public int clickedPointY { get; set; }
        public GameApplication Game { get; set; }
        public CurrentUser User { get; set; }
    }
}