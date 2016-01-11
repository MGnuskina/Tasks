using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGameApplication.Models
{
    public class CurrentUser
    {
        public string ConnectionID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}