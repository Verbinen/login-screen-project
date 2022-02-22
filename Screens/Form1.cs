using LoginScreenProject.Screens;
using System;
using LoginScreenProject.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreenProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            ControlClass ctrl = new ControlClass();
            ctrl.Acess(tBLogin.Text, tBPwd.Text);

            if (ctrl.GetMsg().Equals(""))
            {
                if (ctrl.GetHasLogin())
                {
                    MessageBox.Show("Login Succesful", "Loading...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WelcomeForm wf = new WelcomeForm();
                    wf.Show();
                }
                else
                {
                    MessageBox.Show("email or password incorrect", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(ctrl.GetMsg());
            }
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
    }
}
