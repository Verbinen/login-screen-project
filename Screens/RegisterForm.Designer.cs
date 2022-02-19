namespace LoginScreenProject.Screens
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.textBoxLoginRegister = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelLoginRegister = new System.Windows.Forms.Label();
            this.labelPwdRegister = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegisterUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterUser.Location = new System.Drawing.Point(92, 262);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(100, 36);
            this.buttonRegisterUser.TabIndex = 0;
            this.buttonRegisterUser.Text = "Register";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginRegister
            // 
            this.textBoxLoginRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginRegister.Location = new System.Drawing.Point(31, 58);
            this.textBoxLoginRegister.Name = "textBoxLoginRegister";
            this.textBoxLoginRegister.Size = new System.Drawing.Size(161, 26);
            this.textBoxLoginRegister.TabIndex = 1;
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(31, 127);
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(161, 26);
            this.textBoxPasswordRegister.TabIndex = 2;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(31, 195);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(161, 26);
            this.textBoxConfirmPassword.TabIndex = 3;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // labelLoginRegister
            // 
            this.labelLoginRegister.AutoSize = true;
            this.labelLoginRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginRegister.Location = new System.Drawing.Point(28, 37);
            this.labelLoginRegister.Name = "labelLoginRegister";
            this.labelLoginRegister.Size = new System.Drawing.Size(55, 18);
            this.labelLoginRegister.TabIndex = 4;
            this.labelLoginRegister.Text = "LOGIN:";
            // 
            // labelPwdRegister
            // 
            this.labelPwdRegister.AutoSize = true;
            this.labelPwdRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPwdRegister.Location = new System.Drawing.Point(28, 106);
            this.labelPwdRegister.Name = "labelPwdRegister";
            this.labelPwdRegister.Size = new System.Drawing.Size(86, 18);
            this.labelPwdRegister.TabIndex = 5;
            this.labelPwdRegister.Text = "PASSWORD:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(28, 174);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(148, 18);
            this.labelConfirmPassword.TabIndex = 6;
            this.labelConfirmPassword.Text = "CONFIRM PASSWORD";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 310);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPwdRegister);
            this.Controls.Add(this.labelLoginRegister);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPasswordRegister);
            this.Controls.Add(this.textBoxLoginRegister);
            this.Controls.Add(this.buttonRegisterUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.TextBox textBoxLoginRegister;
        private System.Windows.Forms.TextBox textBoxPasswordRegister;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelLoginRegister;
        private System.Windows.Forms.Label labelPwdRegister;
        private System.Windows.Forms.Label labelConfirmPassword;
    }
}