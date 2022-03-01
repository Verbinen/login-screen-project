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
        public bool has;
        private String msg = "";
        public void Acess(String login, String pwd)
        {
            LoginDaoCommands loginDao = new LoginDaoCommands();
            this.has = loginDao.VerifyLogin(login, pwd);

            String msg = loginDao.GetMsg();
            if (!msg.Equals(""))
            {
                this.msg = msg;
            }

        }

        public String Register(String email, String pwd, String pwd2)
        {
            LoginDaoCommands loginDao = new LoginDaoCommands();
            this.msg = loginDao.Register(email, pwd, pwd2);
            if (loginDao.has)
            {
                this.has = true;
            }

            return msg;
        }

        public String GetMsg()
        {
            return this.msg;
        }

    }
}
