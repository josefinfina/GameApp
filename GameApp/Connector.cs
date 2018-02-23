using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class Connector
    {

        public static SqlConnection GetConnection ()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KMIM16D;Initial Catalog=GameDB;Integrated Security=True");
            
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
