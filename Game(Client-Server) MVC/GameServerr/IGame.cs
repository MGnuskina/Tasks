using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    public interface IGame
    {
        //int[,] CurrentFieldState { get; set; }
        string Title { get;}
        bool gameOver { get; set; }
        int width { get; set; }
        int height { get; set; }
        bool Move(int player, int X, int Y, out List<int[]> pointFrom, out string[] objToDraw, out string color, out bool gameIsFinished, out bool isAWiner);
        void AdditionalDrawing(out string[] objTODraw, out List<int[]> pointsToDrawFrom);
    }
}
