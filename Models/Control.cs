using LoginScreenProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreenProject.Models
{
    public class Control
    {
        private bool hasLogin;
        public String msg = "";
        public bool Acess(String login, String pwd)
        {
            LoginDaoCommands loginDao = new LoginDaoCommands();
            this.hasLogin = loginDao.VerifyLogin(login, pwd);

            if (!loginDao.msg.Equals(""))
            {
                this.msg = loginDao.msg;
            }
            return hasLogin;

        }

        public String Register(String email, String pwd, String pwd2)
        {
            return msg;
        }

    }
}
