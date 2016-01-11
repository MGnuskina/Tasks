using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rates
{
    public class Rates
    {
        int IDOfUser { get; set; }
        int IDOfGame { get; set; }
        int NumOfWins { get; set; }
        int NumOfGamesPlayed { get; set; }

        //public Rates(int ID, int IDofGame, bool isAWinner)
        //{
        //    this.ID = ID;
        //    this.IDOfGame = IDOfGame;
        //    this.NumOfGamesPlayed = 1;
        //    this.NumOfWins = isAWinner ? 1 : 0;
        //}

        //public int NumberOfGamesLost()
        //{
        //    return NumOfGamesPlayed - NumOfWins;
        //}

        //public bool AddAGamePlayed(bool isAWinner)
        //{
        //    NumOfWins = NumOfWins + (isAWinner ? 1 : 0);
        //    return true;
        //}
    }
}
