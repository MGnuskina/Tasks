using System.Collections.Generic;
using System.Linq;

namespace Autorization
{
    public class PlayerRepository
    {
        static PlayerContext context = new PlayerContext();

        public static bool Create(Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
            return true;
        }

        public bool Update(Player player, string password)
        {
            return true;
        }

        public Player Read(int ID)
        {
            Player player = context.Players.Find(ID);
            return player;
        }

        public static Player AuthorizationCheck(string name, string password)
        {
            Player player = null;
            player = context.Players.SingleOrDefault(user => user.Name == name && user.Password == password);
            return player;
        }

        public static Player AuthorizationCheck(string name)
        {
            Player player = null;
            player = context.Players.SingleOrDefault(user => user.Name == name);
            return player;
        }

        public static List<Player> FindAllPlayers()
        {
            List<Player> players = new List<Player>();
            if (context.Players != null)
            {
                 players = context.Players.ToList();
            }
            return players;
        }

        public bool Delete(int ID)
        {
            context.Players.Remove(context.Players.Find(ID));
            return true;
        }
    }
}
