using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class Player
    {
        public string username { get; set; }
        public string password { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{username} {username}";
            }
        }

    }

}
