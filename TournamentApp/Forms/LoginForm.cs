using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
using TournamentApp.Forms;
using TournamentApp.Models;

namespace TournamentApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registrationButtom_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                string login = loginBox.Text;
                string password = passwordBox.Text;
                var users = db.Users.ToList();

                if (users.Count != 0)
                {
                    foreach (var item in users)
                    {
                        if (item.Login == login)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует.");
                            return;
                        }
                    }
                }

                if (Verification() == false)
                {
                    return;
                }

                RegistartionForm registartionForm = new RegistartionForm();
                registartionForm.loginForm = this;
                registartionForm.User = new User() { Login = login, Password = password };
                registartionForm.Show();
                this.Hide();
            }
        }

        private void loginButtom_Click(object sender, EventArgs e)
        {
            if (Verification() == false)
            {
                return;
            }
            using (var db = new ApplicationDbContext())
            {
                var userProf = db.Users.Include(x => x.UserProfile).FirstOrDefault(x => x.Login == loginBox.Text && x.Password == passwordBox.Text);
                if (userProf != null)
                {
                    TournamentForm tournamentForm = new TournamentForm();
                    tournamentForm.loginForm = this;
                    tournamentForm.User = userProf;
                    tournamentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Невозможно найти такого пользователя!");
                }
            }
        }

        private bool Verification()
        {
            if (loginBox.Text == string.Empty || passwordBox.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполнены!");
                return false;
            }
            return true;
        }
    }
}
