using GameQuiz.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz.Controller
{
    class DataAccessLayer
    {
        public void AddPlayer(string Username, string Password) 
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = "INSERT INTO Player(username, password) VALUES (@username, @password)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = Username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = Password;
             
                cmd.ExecuteNonQuery();
            }
        }
        public Player FindPlayer(string Username, string Password) 
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = string.Format("SELECT username, password FROM Player WHERE username = '{0}' AND password = '{1}'", Username, Password);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                
                    while (dr.Read())
                    {
                        Player player = new Player();
                        player.Username = dr["username"] as string;
                        player.Password = dr["password"] as string;
                        return player;
                    }
                return null;
            }
        }
        public Plays FindPlayerInTblPlays(string Username) 
        {
            using (SqlConnection connection = Connector.GetConnection())
            { 
                string query = string.Format("SELECT username FROM Plays WHERE username = '{0}'", Username);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Plays player = new Plays();
                    player.Username= dr["username"] as string;
                    return player;
                }
                return null;
            }
        }
        public Question FindQuestion() 
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = string.Format("SELECT TOP 1 questTxt, answer FROM Question ORDER BY NEWID()");
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    Question question = new Question();
                    question.questTxt = dr["questTxt"] as string;
                    question.answer = dr["answer"] as string;
                    return question;
                }
         
                return null;
            }
        }
        public Plays FindPlayerPoints(Plays currentPlayer) //Returnera en spelares poäng
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = string.Format("SELECT points FROM Plays WHERE username = '{0}'", currentPlayer.Username);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Plays playerPoints = new Plays();
                    playerPoints.points = Convert.ToInt32(dr["points"]);
                    return playerPoints;
                }
                return null;
            }
        }
        public DataTable FindHighscoreList()
        {
            SqlConnection cnn = Connector.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 10 username Användarnamn, points as Highscore FROM Plays ORDER BY points DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            return dt;
        }
        public void UpdatePlayerHighscore(int points, Plays currentPlayer)
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = string.Format("UPDATE Plays SET points = @add WHERE USERNAME = '{0}'", currentPlayer.Username);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@add", points);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateNewPlayerHighscore(string Username, int quizID, int points)
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = "insert into Plays values(@points, @uname, @qID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@points", points);
                cmd.Parameters.AddWithValue("@uname", Username);
                cmd.Parameters.AddWithValue("@qID", quizID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}