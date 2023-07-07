using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Models
{
    public class Grid
    {
        public int Id { get; set; }
        public DateTime TournamentDate { get; private set; }
        public List<User> Users { get; set; }
        public List<UsersInGrids> UsersInGrids { get; set; }
        public int MinPlayers { get; } = 8;
        public int MaxPlayers { get; } = 16;
        public int PlayersCount { get { return GetPlayersCount(Users.Count); } }
        public bool TournamentStatus { get; set; } = false;

        public Grid()
        {
            TournamentDate = DateTime.Now;
            Users = new List<User>();
        }

        private int GetPlayersCount(int users)
        {
            int n = 2;
            int minPlayers = MinPlayers;
            while (true)
            {
                if (users > minPlayers * n)
                {
                    minPlayers *= n;
                }
                else
                {
                    return minPlayers * n;
                }
            }
        }
        public bool TournamentStatusCheck()
        {
            return TournamentStatus;
        }
        public void ChangeTournamentStatus(bool arg)
        {
            TournamentStatus = arg;
        }
    }
}
