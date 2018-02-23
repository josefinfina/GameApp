using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz.Controller
{
    class Connector
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=GameDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException sqle)
            {
                throw sqle;
            }
        }
    }
}

