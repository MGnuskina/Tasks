using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using MVCGameApplication;

[assembly: OwinStartup(typeof(MVCGameApplication.Startup))]
namespace MVCGameApplication
{
	public class Startup
	{
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
	}
}