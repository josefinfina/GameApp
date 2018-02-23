using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace GameApp
{
    public class DAL
    {
        public List<Player> GetPlayers(string username) // Baltzars exempel
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = "SELECT * FROM Player WHERE (@username AND @password)";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                List<Player> players = new List<Player>();

                while (dr.Read())
                {
                    Player player = new Player();
                    player.username = dr["username"] as string;
                    players.Add(player);
                }

                return players;
            }
        }

       

        public void AddPlayer(string username, string password) //Registrerar en användare
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = "INSERT INTO Player(username, password) VALUES (@username, @password)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = password;

                cmd.ExecuteNonQuery();

            }

        }


        public Player FindPlayers(string username, string password) //Hittar användaren om den finns och loggar in (se LoginForm)
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = string.Format("SELECT username, password FROM Player WHERE username = '{0}' AND password = '{1}'", username, password);

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                
                while (dr.Read())
                {
                    Player player = new Player();
                    player.username = dr["username"] as string;
                    player.password = dr["password"] as string;
                    return player;
                }

                return null;

            }
        }


        public Question FindQuestion() //Returnera en fråga slumpmässigt
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


            }
            return null;
        }



        //public List<Plays> FindHighscore() //Returnera highscore-lista
        //{
        //    using (SqlConnection connection = Connector.GetConnection())
        //    {
        //        string query = string.Format("SELECT TOP 10 points, username FROM Plays ORDER BY points DESC");

        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        DataSet highscore = new List<DataSet>();

        //        //while (dr.Read())
        //        //{
        //        //    Plays plays = new Plays();
        //        //    plays.points = Convert.ToInt32(dr["points"]);
        //        //    plays.username = dr["username"] as string;
        //        //    highscore.Add(plays);

        //        //}
        //        return highscore;


        //    }
            

        //}

        public Plays FindPlayerPoints(Player currentUser) //Returnerar en spelares poäng
        {
            using (SqlConnection connection = Connector.GetConnection())
            {
                string query = string.Format("SELECT points FROM Plays WHERE username = '{0}'", currentUser.username);
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



    }
}

 






