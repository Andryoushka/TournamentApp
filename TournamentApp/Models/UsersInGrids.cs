using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Models
{
    public class UsersInGrids
    {
        public int GridId { get; set; }
        public Grid Grid { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
