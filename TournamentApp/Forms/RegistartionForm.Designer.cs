namespace TournamentApp.Forms
{
    partial class RegistartionForm
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
            label = new Label();
            label1 = new Label();
            userName = new TextBox();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlLightLight;
            label.Location = new Point(259, 9);
            label.Name = "label";
            label.Size = new Size(279, 59);
            label.TabIndex = 0;
            label.Text = "Регистрация:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(297, 167);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 1;
            label1.Text = "Введите имя пользователя:";
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(282, 191);
            userName.Name = "userName";
            userName.Size = new Size(235, 50);
            userName.TabIndex = 2;
            // 
            // registrationButton
            // 
            registrationButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            registrationButton.Location = new Point(282, 247);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(235, 40);
            registrationButton.TabIndex = 3;
            registrationButton.Text = "Зарегистрироваться!";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // RegistartionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(registrationButton);
            Controls.Add(userName);
            Controls.Add(label1);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistartionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistartionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label1;
        private TextBox userName;
        private Button registrationButton;
    }
}