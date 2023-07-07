using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentApp.DataBase;
using TournamentApp.Models;

namespace TournamentApp.Forms
{
    public partial class TournamentForm : Form
    {
        public LoginForm loginForm;
        public User User;
        public int tournamentId;
        private bool isCLosing = false;
        public TournamentForm()
        {
            InitializeComponent();
        }

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            userLabel.Text += $" {User.UserProfile.Name}";

            using (var db = new ApplicationDbContext())
            {
                var tourList = db.Grids.ToList();
                int n = 0;
                int offset = 45;
                foreach (var item in tourList)
                {
                    var buttom = new Button();
                    buttom.BackColor = Color.White;
                    buttom.Text = $"Tournament #{item.Id}";
                    buttom.Location = new Point(15, 50 + n * offset);
                    buttom.Size = new Size(150, 30);
                    buttom.Name = $"buttom{n}";
                    buttom.MouseClick += Buttom_MouseClick;
                    tournamentPanel.Controls.Add(buttom);
                    n++;
                }
            }
        }

        private void Buttom_MouseClick(object? sender, MouseEventArgs e)
        {
            ClearInfoPanel();
            if (enterPanel.Controls.Count != 0)
            {
                enterPanel.Controls.Clear();
            }

            if (sender is Button button)
            {
                var str = button.Text.ToCharArray();
                tournamentId = int.Parse(str[str.Length - 1].ToString());
            }

            Button registrationButton = new Button();
            registrationButton.Name = "registrationButton";
            registrationButton.Text = "Подтвердить регистрацию";
            registrationButton.Font = new Font(FontFamily.GenericSansSerif, 16f);
            registrationButton.AutoSize = true;
            registrationButton.Location = new Point(0, 30);
            registrationButton.MouseClick += RegistrationButton_MouseClick;
            enterPanel.Controls.Add(registrationButton);

            Button enterButton = new Button();
            enterButton.Name = "enterButton";
            enterButton.Text = "Приянть участие";
            enterButton.Font = new Font(FontFamily.GenericSansSerif, 16f);
            enterButton.AutoSize = true;
            enterButton.Location = new Point(0, 80);
            enterButton.MouseClick += EnterButton_MouseClick;
            enterPanel.Controls.Add(enterButton);

            string tournamentStatus;
            using (var db = new ApplicationDbContext())
            {
                bool stat = db.Grids.FirstOrDefault(x => x.Id == tournamentId).TournamentStatus;

                if (stat == false)
                {
                    tournamentStatus = "Статус турнира: Ожидает начала";
                }
                else
                {
                    tournamentStatus = "Статус турнира: Завершен";
                }
            }

            Label status = new Label();
            status.Name = "statusLabel";
            status.BackColor = Color.White;
            status.ForeColor = Color.Black;
            status.Text = tournamentStatus;
            status.AutoSize = true;
            status.Font = new Font(FontFamily.GenericSansSerif, 12f);
            status.Location = new Point(0, 130);
            enterPanel.Controls.Add(status);

            ShowInfoPanel();
        }
        private void EnterButton_MouseClick(object? sender, MouseEventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var grid = db.Grids.Include(x => x.Users).FirstOrDefault(x => x.Id == tournamentId);

                if (grid.TournamentStatusCheck()==true)
                {
                    MessageBox.Show("Турнир завершен!");
                    return;
                }

                if (grid.Users.FirstOrDefault(x => x.Id == User.Id) == null)
                {
                    MessageBox.Show("Вам нужно зарегистрировться на турнир.");
                    return;
                }
            }

            GridForm gridForm = new GridForm(tournamentId);
            gridForm.tournamentForm = this;
            gridForm.loginForm = loginForm;
            gridForm.Show();
            this.Hide();
        }
        private void RegistrationButton_MouseClick(object? sender, MouseEventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var grid = db.Grids.Include(x => x.Users).FirstOrDefault(x => x.Id == tournamentId);

                if (grid.Users.FirstOrDefault(x => x.Id == User.Id) == null)
                {
                    if (grid.Users.Count >= 8)
                    {
                        MessageBox.Show("Простите, все места заняты.");
                        return;
                    }

                    ClearInfoPanel();
                    grid.Users.Add(User);
                    db.SaveChanges();
                    ShowInfoPanel();
                    MessageBox.Show("Заявка на участие прияната!");
                }
                else
                {
                    MessageBox.Show("Вы уже зарегистрировались на участие!");
                }
            }
        }
        private void ClearInfoPanel()
        {
            if (infoPanel.Controls.Count != 0)
            {
                infoPanel.Controls.Clear();
            }
        }
        private void ShowInfoPanel()
        {
            using (var db = new ApplicationDbContext())
            {
                var grids = db.Grids.Include(x => x.Users).FirstOrDefault(x => x.Id == tournamentId);
                var users = db.UsersProfile.ToList();

                int n = 0;
                int offset = 25;
                if (grids != null)
                {
                    var usersProfile = grids.Users.Join(users,
                        u => u.Id,
                        p => p.Id,
                        (u, p) => new { Name = p.Name }).ToList();
                    foreach (var items in usersProfile)
                    {
                        var log = new Label();
                        log.Text = items.Name;
                        log.BorderStyle = BorderStyle.FixedSingle;
                        log.Location = new Point(10, 10 + offset * n);
                        log.Cursor = Cursors.Hand;
                        infoPanel.Controls.Add(log);
                        n++;
                    }
                }
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            loginForm.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
