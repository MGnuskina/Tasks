using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization
{
    public class Player
    {
        private static int nextId=1;
        [Key]
        public int ID { get; set; }//no set
        public bool isWinner { get; set; }
        public bool isActive { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Player(string Name, string Password)
        {
            this.ID = nextId;
            nextId++;
            this.Name = Name;
            this.Password = Password;
            this.isActive = false;
            this.isWinner = false;
        }

        public Player() { }
    }
}
