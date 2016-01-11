using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    public abstract class Game : IGame
    {
        private int[,] CurrentFieldState { get; set; }

        public bool gameOver { get; set; }

        public int height { get; set; }

        public string Title { get; }

        public int width { get; set; }

        public abstract void AdditionalDrawing(out string[] objTODraw, out List<int[]> pointsToDrawFrom);

        public abstract bool Move(int player, int X, int Y, out List<int[]> pointFrom, out string[] objToDraw, out string color, out bool gameIsFinished, out bool isAWiner);

        private int[] FindClickedPlace(int X, int Y) { return new int[0]; }

        private void CheckEnd() { }

        private bool CheckExistenceInTheArray(int ii, int jj) { return false; }
    }
}
