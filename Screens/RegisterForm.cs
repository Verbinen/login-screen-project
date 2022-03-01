using LoginScreenProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreenProject.Screens
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            ControlClass control = new ControlClass();
            String msg = control.Register(textBoxLoginRegister.Text, textBoxPasswordRegister.Text, textBoxConfirmPassword.Text);
            if (control.has)
            {
                MessageBox.Show(msg, "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(control.GetMsg());
            }
            this.Close();

        }
    }
}
