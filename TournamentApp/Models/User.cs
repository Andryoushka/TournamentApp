using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserProfile UserProfile { get; set; }
        public List<Grid> Grid { get; set; }
        public List<UsersInGrids> UsersInGrids { get; set; }
    }
}
