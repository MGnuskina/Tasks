using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer
{
    public class GameApplication
    {
        public IGame game;

        public static List<string> GameNames = new List<string>() { "Tick_Tack_Toe", "Numbers" };

        private static GameApplication instance;

        public GameApplication() { }

        public static GameApplication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameApplication();
                }
                return instance;
            }
        }

        public void CreateGame(string gameName, int fieldWidth, int fieldHeight, out List<int[]> pointsFrom, out List<int[]> pointsTO, out int drawSize)///обобщить
        {
            switch (gameName)
            {
                case "Tick_Tack_Toe":
                    game = new TickTackToeGame(fieldWidth, fieldHeight, out pointsFrom, out pointsTO, out drawSize);
                    break;
                case "Numbers":
                    game = new NumbersGame(fieldWidth, fieldHeight, out pointsFrom, out pointsTO, out drawSize);
                    break;
                default:
                    throw new AggregateException("No game under this index.");
            }
        }

        public bool PlayersMove(int playerID,int X, int Y, out List<int[]> pointFrom, out string[] objToDraw, out string drawBrush, out bool gameIsFinished, out bool isAWinner)///return
        {
            return game.Move(playerID ,X, Y, out pointFrom, out objToDraw,  out drawBrush, out gameIsFinished, out isAWinner);
        }

        public void AdditionalDrawingBeforeGame(out string[] objToDraw, out List<int[]> pointsToDraw)
        {
            game.AdditionalDrawing(out objToDraw, out pointsToDraw);
        }
        
        public string ReqestAUserParticipation()
        {
            return "Are you willing to play a" + game.Title + "game?";
        }
    }
}
