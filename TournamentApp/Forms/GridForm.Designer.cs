namespace TournamentApp.Forms
{
    partial class GridForm
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
            gridPanel = new Panel();
            SuspendLayout();
            // 
            // gridPanel
            // 
            gridPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            gridPanel.Dock = DockStyle.Fill;
            gridPanel.Location = new Point(0, 0);
            gridPanel.Name = "gridPanel";
            gridPanel.Size = new Size(800, 450);
            gridPanel.TabIndex = 0;
            // 
            // GridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(gridPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GridForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GridForm";
            Load += GridForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel gridPanel;
    }
}