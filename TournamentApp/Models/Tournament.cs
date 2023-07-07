using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.DataBase;

namespace TournamentApp.Models
{
    public class Tournament
    {
        public int TournamentId;
        public List<string> Users { get; set; }
        public Tree<string> Tree { get; private set; }
        public int PlayersCount = 8;
        private Random random = new Random();

        public Tournament(int id)
        {
            TournamentId = id;
        }

        public void TournamentPreparation()
        {
            List<string> list_buffer = new List<string>();

            using (var db = new ApplicationDbContext())
            {
                var grid = db.Grids.Include(x => x.Users).FirstOrDefault(x=> x.Id == TournamentId);
                var users = grid.Users.Join(db.UsersProfile.ToList(),
                    u => u.Id,
                    p => p.Id,
                    (u,p) => new { UserID = u.Id, UserName = p.Name }
                    ).ToList();

                foreach (var item in users)
                {
                    list_buffer.Add(item.UserName);
                }
            }

            if (list_buffer.Count < PlayersCount) // Добавление в список нехватающих "пустых" участников
            {
                int tba = PlayersCount - list_buffer.Count;
                for (int i = 0; i < tba; i++)
                {
                    list_buffer.Add("TBA");
                }
            }
            Tree = new Tree<string>();
            for (int i = PlayersCount - 1; i >= 1; i--) // Промежуточные узлы
            {
                Tree.Add(i + 0.5f, "TBA");
            }
            for (int i = 1; i <= PlayersCount; i++) // Листья
            {
                int number = random.Next(0, list_buffer.Count);
                Tree.Add(i, list_buffer[number]);
                list_buffer.RemoveAt(number);
            }
        }
        private void Fight<T>(Node<T> node)
        {
            var strLeft = node.Left.Data;
            var strRight = node.Right.Data;

            //var leftPlayer = usersDB.Find(p => p.Id == strLeft.ToString());
            //var rightPlayer = usersDB.Find(p => p.Id == strRight.ToString());

            UserProfile leftPlayer;
            UserProfile rightPlayer;

            using ( var db = new ApplicationDbContext() ) 
            {
                leftPlayer = db.UsersProfile.FirstOrDefault(x => x.Name == strLeft.ToString());
                rightPlayer = db.UsersProfile.FirstOrDefault(x => x.Name == strRight.ToString());
            }

            if (leftPlayer == null && rightPlayer == null)
            {
                return;
            }
            else if (leftPlayer == null && rightPlayer != null)
            {
                node.Data = strRight;
                node.Right.Victory = true;
                return;
            }
            else if (leftPlayer != null && rightPlayer == null)
            {
                node.Data = strLeft;
                node.Left.Victory = true;
                return;
            }

            int attackingPlayer;

            while (true)
            {
                attackingPlayer = random.Next(-1, 2);

                switch (attackingPlayer)
                {
                    case -1:
                        if (leftPlayer.HP > 0)
                        {
                            rightPlayer.HP -= 60;
                        }
                        else
                        {
                            node.Data = strRight;
                            node.Right.Victory = true;
                            return;
                            //break;
                        }
                        break;

                    case 1:
                        if (rightPlayer.HP > 0)
                        {
                            leftPlayer.HP -= 60;
                        }
                        else
                        {
                            node.Data = strLeft;
                            node.Left.Victory = true;
                            return;
                            //break;
                        }
                        break;

                    default: break;
                }
            }
        }
        private bool HasChildren<T>(Node<T> node)
        {
            if (node.Left != null && node.Right != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SearchBattle<T>(Node<T> node)
        {
            if (HasChildren(node) == false) return;
            //if (node.Left.Player == null)
            //{
            SearchBattle(node.Left);
            //}
            //if (node.Right.Player == null)
            //{
            SearchBattle(node.Right);
            //}
            Fight(node);
        }
        public void BeginTournament()
        {
            SearchBattle(Tree.Root);
        }
    }
}
