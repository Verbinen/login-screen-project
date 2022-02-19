namespace LoginScreenProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.tBPwd = new System.Windows.Forms.TextBox();
            this.pictureBoxLocker = new System.Windows.Forms.PictureBox();
            this.buttonENTER = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(187, 79);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 18);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN:";
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPwd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPwd.Location = new System.Drawing.Point(187, 128);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(86, 18);
            this.labelPwd.TabIndex = 1;
            this.labelPwd.Text = "PASSWORD:";
            // 
            // tBLogin
            // 
            this.tBLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBLogin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBLogin.Location = new System.Drawing.Point(279, 74);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(121, 23);
            this.tBLogin.TabIndex = 2;
            // 
            // tBPwd
            // 
            this.tBPwd.AllowDrop = true;
            this.tBPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPwd.Location = new System.Drawing.Point(279, 126);
            this.tBPwd.Name = "tBPwd";
            this.tBPwd.Size = new System.Drawing.Size(121, 20);
            this.tBPwd.TabIndex = 3;
            this.tBPwd.UseSystemPasswordChar = true;
            this.tBPwd.UseWaitCursor = true;
            // 
            // pictureBoxLocker
            // 
            this.pictureBoxLocker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLocker.Image")));
            this.pictureBoxLocker.Location = new System.Drawing.Point(31, 72);
            this.pictureBoxLocker.Name = "pictureBoxLocker";
            this.pictureBoxLocker.Size = new System.Drawing.Size(133, 128);
            this.pictureBoxLocker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLocker.TabIndex = 4;
            this.pictureBoxLocker.TabStop = false;
            // 
            // buttonENTER
            // 
            this.buttonENTER.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENTER.Location = new System.Drawing.Point(202, 191);
            this.buttonENTER.Name = "buttonENTER";
            this.buttonENTER.Size = new System.Drawing.Size(75, 23);
            this.buttonENTER.TabIndex = 5;
            this.buttonENTER.Text = "ENTER";
            this.buttonENTER.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(309, 191);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(250, 220);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(93, 23);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonENTER);
            this.Controls.Add(this.pictureBoxLocker);
            this.Controls.Add(this.tBPwd);
            this.Controls.Add(this.tBLogin);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.TextBox tBPwd;
        private System.Windows.Forms.PictureBox pictureBoxLocker;
        private System.Windows.Forms.Button buttonENTER;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRegister;
    }
}

