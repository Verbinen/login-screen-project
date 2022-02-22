using LoginScreenProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreenProject.Models
{
    public class ControlClass
    {
        private bool hasLogin;
        private String msg = "";
        public void Acess(String login, String pwd)
        {
            LoginDaoCommands loginDao = new LoginDaoCommands();
            this.hasLogin = loginDao.VerifyLogin(login, pwd);

            String msg = loginDao.GetMsg();
            if (!msg.Equals(""))
            {
                this.msg = msg;
            }

        }

        public String Register(String email, String pwd, String pwd2)
        {
            return msg;
        }

        public bool GetHasLogin()
        {
            return hasLogin;
        }

        public String GetMsg()
        {
            return this.msg;
        }

    }
}
