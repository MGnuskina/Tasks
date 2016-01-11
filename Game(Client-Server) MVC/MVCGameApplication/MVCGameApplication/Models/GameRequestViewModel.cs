using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGameApplication.Models
{
	public class GameRequestViewModel
	{
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string GameName { get; set; }
	}
}