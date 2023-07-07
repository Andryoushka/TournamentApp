namespace TournamentApp.Forms
{
    partial class TournamentForm
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
            tournamentPanel = new Panel();
            infoPanel = new Panel();
            playersList = new Label();
            tournamentsList = new Label();
            userLabel = new Label();
            enterPanel = new Panel();
            backButton = new Button();
            SuspendLayout();
            // 
            // tournamentPanel
            // 
            tournamentPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            tournamentPanel.Location = new Point(0, 56);
            tournamentPanel.Name = "tournamentPanel";
            tournamentPanel.Size = new Size(207, 394);
            tournamentPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            infoPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            infoPanel.Location = new Point(540, 56);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(260, 272);
            infoPanel.TabIndex = 1;
            // 
            // playersList
            // 
            playersList.AutoSize = true;
            playersList.BackColor = Color.FromArgb(0, 0, 0, 0);
            playersList.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            playersList.ForeColor = SystemColors.ButtonHighlight;
            playersList.Location = new Point(575, 9);
            playersList.Name = "playersList";
            playersList.Size = new Size(213, 30);
            playersList.TabIndex = 2;
            playersList.Text = "Список участников:";
            // 
            // tournamentsList
            // 
            tournamentsList.AutoSize = true;
            tournamentsList.BackColor = Color.FromArgb(0, 0, 0, 0);
            tournamentsList.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentsList.ForeColor = SystemColors.ButtonHighlight;
            tournamentsList.Location = new Point(12, 9);
            tournamentsList.Name = "tournamentsList";
            tournamentsList.Size = new Size(195, 30);
            tournamentsList.TabIndex = 3;
            tournamentsList.Text = "Список турниров:";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.Location = new Point(253, 9);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(150, 21);
            userLabel.TabIndex = 4;
            userLabel.Text = "Добро пожаловать:";
            // 
            // enterPanel
            // 
            enterPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            enterPanel.Location = new Point(213, 121);
            enterPanel.Name = "enterPanel";
            enterPanel.Size = new Size(312, 265);
            enterPanel.TabIndex = 5;
            // 
            // backButton
            // 
            backButton.Location = new Point(297, 415);
            backButton.Name = "backButton";
            backButton.Size = new Size(133, 23);
            backButton.TabIndex = 6;
            backButton.Text = "Выйти из профиля";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // TournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(enterPanel);
            Controls.Add(userLabel);
            Controls.Add(tournamentsList);
            Controls.Add(playersList);
            Controls.Add(infoPanel);
            Controls.Add(tournamentPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TournamentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TournamentForm";
            Load += TournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel tournamentPanel;
        private Panel infoPanel;
        private Label playersList;
        private Label tournamentsList;
        private Label userLabel;
        private Panel enterPanel;
        private Button backButton;
    }
}