using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.Configutations;
using TournamentApp.Models;

namespace TournamentApp.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        string localDb = "Server=(localdb)\\MSSQLLocalDB;Database=TournamentApp;Trusted_Connection=True";
        string serverDb = "Server=sql8001.site4now.net;Database=db_a9be65_andryoushka7; user id=db_a9be65_andryoushka7_admin; pwd=cs19971204";
        public ApplicationDbContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UsersProfile { get; set; }
        public DbSet<Grid> Grids { get; set; }
        public DbSet<UsersInGrids> UsersInGrids { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: serverDb);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new UserProfileConfig());
            modelBuilder.ApplyConfiguration(new GridConfig());
            modelBuilder.ApplyConfiguration(new UsersInGridsConfig());
        }
    }
}
