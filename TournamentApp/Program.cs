using Microsoft.EntityFrameworkCore;
using TournamentApp.DataBase;
using TournamentApp.Forms;
using TournamentApp.Models;

namespace TournamentApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var db = new ApplicationDbContext())
            //{

            //    db.UsersProfile.Add(new UserProfile { Name = "Andrei", User = new User { Login = "and", Password = "111" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Sergey", User = new User { Login = "ser", Password = "222" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Svetlana", User = new User { Login = "sve", Password = "333" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Dasha", User = new User { Login = "das", Password = "444" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Dima", User = new User { Login = "dim", Password = "555" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Kiril", User = new User { Login = "kir", Password = "666" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Victor", User = new User { Login = "vic", Password = "777" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Diana", User = new User { Login = "dia", Password = "888" } });
            //    db.UsersProfile.Add(new UserProfile { Name = "Sasha", User = new User { Login = "sas", Password = "999" } });
            //    db.SaveChanges();
            //    var users = db.Users.ToList();
            //    var grid1 = new Grid();
            //    grid1.Users.Add(users[0]);
            //    grid1.Users.Add(users[1]);
            //    grid1.Users.Add(users[2]);
            //    grid1.Users.Add(users[3]);
            //    grid1.Users.Add(users[4]);
            //    grid1.Users.Add(users[5]);
            //    grid1.Users.Add(users[6]);
            //    grid1.Users.Add(users[7]);
            //    db.Grids.Add(grid1);
            //    db.SaveChanges();
            //    var grid2 = new Grid();
            //    db.Grids.Add(grid2 );
            //    db.SaveChanges();
            //}

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}