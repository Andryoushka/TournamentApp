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
    public partial class RegistartionForm : Form
    {
        public LoginForm loginForm;
        public User User;
        public RegistartionForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                string name = userName.Text;

                db.UsersProfile.Add(new UserProfile { Name = name , User = User});

                db.SaveChanges();

                MessageBox.Show("Пользователь добавлен!");
                
                loginForm.Show();
                this.Close();
            }
        }
    }
}
