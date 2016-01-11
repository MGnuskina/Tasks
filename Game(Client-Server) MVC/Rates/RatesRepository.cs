using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rates
{
    public class RatesRepository
    {
        public bool Create(Rates rate)
        {
            return true;
        }

        public bool Delete(int userID, int gameID)
        {
            return true;
        }

        public bool Update(int userID, int gameID, bool isWinner)
        {
            return true;
        }

        public Rates Read(int userID, int gameID)
        {
            Rates rates = new Rates();
            return rates;
        }
    }
}
