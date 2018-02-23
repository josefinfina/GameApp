using GameQuiz.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz.Controller
{
    class Controll
    {
        private DataAccessLayer dal = new DataAccessLayer();

        public void AddPlayer(string username, string password)
        {
            dal.AddPlayer(username, password);
        }
        public Player FindPlayer(string Username, string Password)
        {
            return dal.FindPlayer(Username, Password);
        }
        public Plays FindPlayerInTblPlays(string Username)
        {
            return dal.FindPlayerInTblPlays(Username);
        }
        public DataTable FindHighscoreList()
        {
            return dal.FindHighscoreList();
        }
        public Question FindQuestion()
        {
            return dal.FindQuestion();
        }
        public Plays FindPlayerPoints(Plays currentPlayer)
        {
            return dal.FindPlayerPoints(currentPlayer);
        }
        public void UpdatePlayerHighscore(int points, Plays currentPlayer)
        {
            dal.UpdatePlayerHighscore(points, currentPlayer);
        }
        public void UpdateNewPlayerHighscore(string Username, int quizID, int points)
        {
            dal.UpdateNewPlayerHighscore(Username, quizID, points);
        }
    }
}
