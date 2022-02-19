using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreenProject.DAL
{
    public class LoginDaoCommands
    {
        public bool has;
        public String msg = "";

        public bool VerifyLogin(String login, String pwd)
        {
            //sql commands to verify if the login
            return has;
        }

        public String Register(String email, String pwd, String pwd2)
        {
            //commands to insert user
            return msg;
        }
    }
}
