using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class Controller
    {
        private DAL dal = new DAL();

        public void AddPlayer(string username, string password)
        {
            dal.AddPlayer(username, password);
        }

        public Player FindPlayers(string username, string password)
        {
            return dal.FindPlayers(username, password);
        }

        public Question FindQuestion()
        {
            return dal.FindQuestion();
        }

        //public DataSet FindHighscore()
        //{
        //    return dal.FindHighscore();
        //}

        public Plays FindPlayerPoints(Player currentUser)
        {
            return dal.FindPlayerPoints(currentUser);
        }




    }

}
