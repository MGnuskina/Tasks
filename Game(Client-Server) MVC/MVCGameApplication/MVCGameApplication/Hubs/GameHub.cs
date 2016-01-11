using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using MVCGameApplication.Models;
using System.Threading.Tasks;
using GameServer;

namespace MVCGameApplication.Hubs
{
    public class GameHub : Hub
    {
        static List<CurrentUser> Users = new List<CurrentUser>();
        GameApplication game = null;

        public void Send(string name, string password, GameApplication gameNow)
        {
            if (game == null)
            {
                game = gameNow;
            }
            else
            {
                if (game != gameNow)
                {
                    throw new ArgumentException("Users chouse different games!");
                }
            }

            var connectionID = Context.ConnectionId;
            bool alreadyExists = Users.Any(x => x.Name == name && x.Password == password);
            if (!alreadyExists)
            {
                Users.Add(new CurrentUser() { Name = name, ConnectionID = connectionID, Password = password });
            }

        }

        public void Play(int x, int y)
        {
            var connectionID = Context.ConnectionId;
            int i = 0;
            List<int[]> pointsTo;
            string[] objectToDraw;
            string drawBrush;
            bool gameIsFinished;
            bool isWinner;
            while (i < Users.Count && Users[i].ConnectionID != connectionID)
            {
                i++;
            }
            if (i < Users.Count)
            {
                game.PlayersMove(i, x, y, out pointsTo, out objectToDraw, out drawBrush, out gameIsFinished, out isWinner);
                ///refer to js
                Clients.All.onMove(objectToDraw, drawBrush, pointsTo, Users);
                //check for a win and send alert
            }
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var item = Users.FirstOrDefault(x => x.ConnectionID == Context.ConnectionId);
            if (item != null)
            {
                Users.Remove(item);
            }
            return base.OnDisconnected(stopCalled);
        }
    }
}