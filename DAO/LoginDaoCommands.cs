using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreenProject.DAL
{
    public class LoginDaoCommands
    {
        public bool has = false;
        private String msg = "";
        private SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        Connection sqlCon = new Connection();
        

        public bool VerifyLogin(String login, String pwd)
        {
            //sql commands to verify if the login

            cmd.CommandText = "select * from login where email = @login and password = @pwd";
            cmd.Parameters.AddWithValue("@login", login); 
            cmd.Parameters.AddWithValue("@pwd", pwd); //Pega a senha gravada em pwd e insere no comando sql @pwd

            try
            {
                cmd.Connection = sqlCon.Connect(); //conecta no banco
                this.dr = cmd.ExecuteReader(); //Puxa info do banco executando a linha escrita
                if (dr.HasRows)
                {
                    sqlCon.Disconnect();
                    dr.Close();
                    return true;
                }
            }
            catch (SqlException)
            {
                this.msg = "Database Error";
            }

            return false;
        }

        public String Register(String email, String pwd, String pwd2)
        {
            //commands to insert user
            if (pwd.Equals(pwd2))
            {
                cmd.CommandText = "insert into login values(@email, @pwd);";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pwd", pwd);

                try
                {
                    cmd.Connection = sqlCon.Connect();
                    cmd.ExecuteNonQuery();
                    sqlCon.Disconnect();
                    this.msg = "Registered !";
                    this.has = true;
                }
                catch (SqlException)
                {
                    this.msg = "Database Error";
                }
            }
            else{
                this.msg = "Passowords does not match";
            }
            return msg;
        }

        public String GetMsg()
        {
            return this.msg;
        }
    }
}
