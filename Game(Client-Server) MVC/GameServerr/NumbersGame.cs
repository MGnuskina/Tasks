using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameServer
{
    public class NumbersGame : Game
    {
        private int[,] CurrentFieldState { get; set; }

        public bool gameOver { get; set; }

        public int width { get; set; }
        public int height { get; set; }
        int deltaWidth;
        int deltaHeight;
        string color = "Black";
        int currentEl;

        public string Title
        {
            get
            {
                return "Numbers";
            }
        }

        public NumbersGame(int height, int width, out List<int[]> pointsFrom, out List<int[]> pointsTO, out int objTODrawSize)
        {
            pointsFrom = new List<int[]>();
            pointsTO = new List<int[]>();
            CurrentFieldState = new int[4, 4];
            this.height = height;
            this.width = width;
            Random random = new Random();
            deltaHeight = (int)(height / 4.0);
            deltaWidth = (int)(width / 4.0);
            gameOver = false;
            for (int i = 1; i < 4; i++)
            {
                pointsFrom.Add(new int[2] { (i * deltaWidth), 0 });
                pointsFrom.Add(new int[2] { 0, (i * deltaHeight) });
                pointsTO.Add(new int[2] { (i * deltaWidth), height });
                pointsTO.Add(new int[2] { width, (i * deltaHeight) });
            }
            objTODrawSize = 50;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    CurrentFieldState[i, j] = random.Next(1, 17);
                    while (CheckExistenceInTheArray(i, j))
                    {
                        CurrentFieldState[i, j] = random.Next(1, 17);
                    }
                }
            }
            currentEl = 1;
        }

        private bool CheckExistenceInTheArray(int ii, int jj)
        {
            bool res = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (CurrentFieldState[i, j] == CurrentFieldState[ii, jj] && (ii != i || jj != j))
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        private void CheckEnd()
        {
            int leftFields = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (CurrentFieldState[i, j] > 0)
                    {
                        leftFields++;
                    }
                }
            }
            if (leftFields == 0)
            {
                gameOver = true;
            }
        }

        public override bool Move(int player, int X, int Y, out List<int[]> pointFrom, out string[] objToDraw, out string color, out bool gameIsFinished, out bool isAWinner)
        {
            int[] nowEl = FindClickedPlace(X, Y);
            color = this.color;
            bool res = false;
            isAWinner = false;
            pointFrom = new List<int[]>();
            pointFrom.Add(new int[2] { ((nowEl[0] ) * deltaWidth), ((nowEl[1]) * deltaHeight) });
            objToDraw = new string[1] { CurrentFieldState[nowEl[0], nowEl[1]].ToString() };
            gameIsFinished = gameOver;
            if (CurrentFieldState[nowEl[0], nowEl[1]] == currentEl)
            {
                CurrentFieldState[nowEl[0], nowEl[1]] = -1;
                CheckEnd();
                res = true;
                currentEl++;
                gameIsFinished = gameOver;
            }
            else
            {
                if (CurrentFieldState[nowEl[0], nowEl[1]] > 0)
                {
                    isAWinner = true;
                    res = true;
                    gameIsFinished = true;
                }
            }
            return res;
        }

        private int[] FindClickedPlace(int X, int Y)
        {
            int[] res = new int[2] { -1, -1 };
            int i = 1;
            while (res[0] == -1)
            {
                if (X <= i * deltaWidth)
                {
                    res[0] = i - 1;
                }
                i++;
            }
            i = 1;
            while (res[1] == -1)
            {
                if (Y <= i * deltaHeight)
                {
                    res[1] = i - 1;
                }
                i++;
            }
            return res;
        }

        public override void AdditionalDrawing(out string[] objTODraw, out List<int[]> pointsToDrawFrom)
        {
            objTODraw = new string[16];
            pointsToDrawFrom = new List<int[]>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    objTODraw[i * 4 + j] = CurrentFieldState[i, j].ToString();
                    pointsToDrawFrom.Add(new int[] { i * deltaWidth, j * deltaHeight });
                }
            }
        }
    }
}
