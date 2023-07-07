using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public User User { get; set; }
        public readonly string? UserId;
        public string? Name { get; set; }
        public int HP = 100;
        public int Damage = 5;
        public int Victoris { get; private set; }
        public UserProfile(){}
        public UserProfile(string userName)//, int damage)
        {
            Name = userName ?? throw new ArgumentException("Имя пользователя не назначено!", nameof(userName));
            UserId = Guid.NewGuid().ToString();
            Damage = 0;
            Victoris = 0;
        }
        public override string ToString()
        {
            return Name;
        }
        public void AddVictoris()
        {
            Victoris++;
        }
    }
}
