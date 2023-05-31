using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreenProject.DAL
{
    public class Connection
    {
        SqlConnection sqlCon = new SqlConnection();
        public Connection()
        {
            sqlCon.ConnectionString = @"Data Source=DESKTOP-DUDU\SQLEXPRESS;Initial Catalog=LoginProject;Integrated Security=True";

        }

        public SqlConnection Connect()
        {
            if(sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            return sqlCon;
        }
        public void Disconnect()
        {
            if(sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }

        }
    }
}
