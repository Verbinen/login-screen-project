namespace LoginScreenProject.Screens
{
    partial class WelcomeForm
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
            this.textBoxWelcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxWelcome
            // 
            this.textBoxWelcome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxWelcome.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWelcome.Location = new System.Drawing.Point(39, 70);
            this.textBoxWelcome.Name = "textBoxWelcome";
            this.textBoxWelcome.Size = new System.Drawing.Size(377, 97);
            this.textBoxWelcome.TabIndex = 0;
            this.textBoxWelcome.Text = "Welcome!";
            this.textBoxWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(475, 262);
            this.Controls.Add(this.textBoxWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWelcome;
    }
}