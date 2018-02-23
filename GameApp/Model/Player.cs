using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz.Model
{
    class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Player() { }

        public Player(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
