using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using MVCGameApplication.Models;

namespace MVCGameApplication.Hubs
{
    public class UsersHub : Hub
    {
        static List<CurrentUser> Users = new List<CurrentUser>();

        public void Send(string name, string password)
        {
            var connectionID = Context.ConnectionId;
            bool alreadyExists = Users.Any(x => x.Name == name && x.Password == password);
            if (!alreadyExists)
            {
                Users.Add(new CurrentUser() { Name = name, ConnectionID = connectionID, Password = password });
                Clients.AllExcept(connectionID).onNewUserConnected(connectionID, name);
                Clients.Caller.onConnected(connectionID, name, Users);
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