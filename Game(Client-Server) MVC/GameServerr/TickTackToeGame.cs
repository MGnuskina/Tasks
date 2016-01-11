using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    public class TickTackToeGame : Game
    {
        public int[,] CurrentFieldState { get; set; }

        public bool gameOver { get; set; }

        public int width { get; set; }
        public int height { get; set; }
        public int deltaWidth;
        public int deltaHeight;
        string color = "Black";

        public string Title
        {
            get
            {
                return "Tick Tack Toe";
            }
        }

        public TickTackToeGame(int width, int height, out List<int[]> pointsFrom, out List<int[]> pointsTO, out int drawSize)
        {
            pointsTO = new List<int[]>();
            pointsFrom = new List<int[]>();
            CurrentFieldState = new int[3, 3];
            this.height = height;
            this.width = width;
            deltaHeight = (int)(height / 3.0);
            deltaWidth = (int)(width / 3.0);
            gameOver = false;
            for (int i=1; i<3; i++)
            {
                pointsFrom.Add(new int[2]{(i*deltaWidth),0});
                pointsFrom.Add(new int[2] {0,(i * deltaHeight)});
                pointsTO.Add(new int[2] { (i * deltaWidth), height });
                pointsTO.Add(new int[2] { width,(i * deltaHeight) });
            }
            for (int i=0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    CurrentFieldState[i, j] = -1;
                }
            }
            drawSize =90;
        }

        public override bool Move(int player, int X, int Y, out List<int[]> pointFrom, out string[] objToDraw, out string color, out bool gameIsFinished, out bool isAWinner)
        {
            bool res = false;
            gameIsFinished = false;
            isAWinner = false;
            gameOver = false;
            int[] numEl = FindClickedPlace(X, Y);
            int user = player;
            string isXO = user == 0 ? "X" : "O";
            objToDraw = new string[] { isXO };
            color = this.color;
            pointFrom = new List<int[]>();
            pointFrom.Add(new int[] { (int)(numEl[0] * deltaWidth), (int)(numEl[1] * deltaHeight)});
            if (CurrentFieldState[numEl[0], numEl[1]] == -1)
            {
                CurrentFieldState[numEl[0], numEl[1]] = user;
                res = true;
            }
            if (CheckForAWin(user))
            {
                gameOver = true;
                gameIsFinished = gameOver;
                isAWinner = true;
            }
            ////else
            {
                if (CheckIfTHeGameIsFinished(user))
                {
                    gameOver = true;
                    gameIsFinished = gameOver;
                }
            }
            return res;
        }

        private int[] FindClickedPlace(int X, int Y)
        {
            int[] res = new int[2];
            if (X < deltaWidth)
            {
                res[0] = 0;
            }
            else
            {
                if (X < deltaWidth * 2)
                {
                    res[0] = 1;
                }
                else
                {
                    res[0] = 2;
                }
            }
            if (Y < deltaHeight)
            {
                res[1] = 0;
            }
            else
            {
                if (Y < deltaHeight * 2)
                {
                    res[1] = 1;
                }
                else
                {
                    res[1] = 2;
                }
            }
            return res;
        }

        private bool CheckForAWin(int user)
        {
            bool res = false;
            int diegonal1 = 0;
            int diegonal2 = 0;
            int[] lineX = new int[3] { 0, 0, 0 };
            int[] lineY = new int[3] { 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (CurrentFieldState[i, j] == user)
                    {
                        lineX[i]++;
                    }
                    if (CurrentFieldState[j, i] == user)
                    {
                        lineY[i]++;
                    }
                }
                if (CurrentFieldState[i, i] == user)
                {
                    diegonal1++;
                }
                if (CurrentFieldState[i, 2 - i] == user)
                {
                    diegonal2++;
                }
            }
            if (diegonal1 == 3 || diegonal2 == 3)
            {
                res = true;
            }
            int ii = 0;
            while (ii < 3 && res == false)
            {
                if (lineX[ii] == 3)
                {
                    res = true;
                }
                if (lineY[ii] == 3)
                {
                    res = true;
                }
                ii++;
            }
            return res;
        }

        private bool CheckIfTHeGameIsFinished(int user)
        {
            bool res = false;
            int usedCell = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (CurrentFieldState[i, j] != -1)
                    {
                        usedCell++;
                    }
                }
            }
            if (usedCell == 9)
            {
                res = true;
            }
            return res;
        }

        public override void AdditionalDrawing(out string[] objTODraw, out List<int[]> pointsToDrawFrom)
        {
            objTODraw = new string[0];
            pointsToDrawFrom = new List<int[]>();
        }
    }
}
