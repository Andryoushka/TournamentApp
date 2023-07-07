namespace TournamentApp
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
            company = new Label();
            loginBox = new TextBox();
            loginPicture = new PictureBox();
            passwordPicture = new PictureBox();
            passwordBox = new TextBox();
            loginButtom = new Button();
            registrationButtom = new Button();
            ((System.ComponentModel.ISupportInitialize)loginPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).BeginInit();
            SuspendLayout();
            // 
            // company
            // 
            company.AutoSize = true;
            company.BackColor = Color.FromArgb(0, 0, 0, 0);
            company.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            company.Location = new Point(62, 19);
            company.Name = "company";
            company.Size = new Size(679, 30);
            company.TabIndex = 0;
            company.Text = "Локальное сообщество проведения турниров по Mobile Legends";
            company.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginBox
            // 
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Cursor = Cursors.IBeam;
            loginBox.Font = new Font("Segoe UI", 51F, FontStyle.Regular, GraphicsUnit.Point);
            loginBox.Location = new Point(276, 107);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(367, 98);
            loginBox.TabIndex = 1;
            // 
            // loginPicture
            // 
            loginPicture.BackColor = Color.FromArgb(0, 0, 0, 0);
            loginPicture.BackgroundImage = Properties.Resources.user;
            loginPicture.BackgroundImageLayout = ImageLayout.Zoom;
            loginPicture.Location = new Point(122, 107);
            loginPicture.Name = "loginPicture";
            loginPicture.Size = new Size(100, 100);
            loginPicture.TabIndex = 2;
            loginPicture.TabStop = false;
            // 
            // passwordPicture
            // 
            passwordPicture.BackColor = Color.FromArgb(0, 0, 0, 0);
            passwordPicture.BackgroundImage = Properties.Resources.password;
            passwordPicture.BackgroundImageLayout = ImageLayout.Zoom;
            passwordPicture.Location = new Point(122, 223);
            passwordPicture.Name = "passwordPicture";
            passwordPicture.Size = new Size(100, 100);
            passwordPicture.TabIndex = 4;
            passwordPicture.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Cursor = Cursors.IBeam;
            passwordBox.Font = new Font("Segoe UI", 51F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(276, 223);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(367, 98);
            passwordBox.TabIndex = 3;
            // 
            // loginButtom
            // 
            loginButtom.Cursor = Cursors.Hand;
            loginButtom.ForeColor = Color.Black;
            loginButtom.Location = new Point(276, 340);
            loginButtom.Name = "loginButtom";
            loginButtom.Size = new Size(147, 77);
            loginButtom.TabIndex = 5;
            loginButtom.Text = "Войти";
            loginButtom.UseVisualStyleBackColor = true;
            loginButtom.Click += loginButtom_Click;
            // 
            // registrationButtom
            // 
            registrationButtom.Cursor = Cursors.Hand;
            registrationButtom.ForeColor = Color.Black;
            registrationButtom.Location = new Point(496, 340);
            registrationButtom.Name = "registrationButtom";
            registrationButtom.Size = new Size(147, 77);
            registrationButtom.TabIndex = 6;
            registrationButtom.Text = "Зарегистрироваться";
            registrationButtom.UseVisualStyleBackColor = true;
            registrationButtom.Click += registrationButtom_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(registrationButtom);
            Controls.Add(loginButtom);
            Controls.Add(passwordPicture);
            Controls.Add(passwordBox);
            Controls.Add(loginPicture);
            Controls.Add(loginBox);
            Controls.Add(company);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)loginPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label company;
        private TextBox loginBox;
        private PictureBox loginPicture;
        private PictureBox passwordPicture;
        private TextBox passwordBox;
        private Button loginButtom;
        private Button registrationButtom;
    }
}