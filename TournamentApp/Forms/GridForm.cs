using Microsoft.EntityFrameworkCore;
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
    public partial class GridForm : Form
    {
        public Tournament Tournament;
        public TournamentForm tournamentForm;
        public LoginForm loginForm;
        public int tournamentId;

        public GridForm(int tournamentId)
        {
            this.tournamentId = tournamentId;
            Tournament = new Tournament(this.tournamentId);
            InitializeComponent();
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            Tournament.TournamentPreparation();

            InsertPlayersInGrid(Tournament.Tree.Root, (int)Tournament.Tree.Root.NodeId * 50);

            var start = new Button();
            start.Text = "Начать состязание!";
            start.Location = new Point(600, 400);
            start.AutoSize = true;
            start.MouseClick += Start_MouseClick;
            gridPanel.Controls.Add(start);
        }

        private void Start_MouseClick(object? sender, MouseEventArgs e)
        {
            gridPanel.Controls.Clear();
            Tournament.BeginTournament();
            InsertPlayersInGrid(Tournament.Tree.Root, (int)Tournament.Tree.Root.NodeId * 50);
            using(var db = new ApplicationDbContext())
            {
                var grid = db.Grids.FirstOrDefault(x => x.Id == tournamentId);
                grid.ChangeTournamentStatus(true);
                db.SaveChanges();
            }

            ShowWinner();

            var back = new Button();
            back.Text = "Вернуться назад";
            back.Location = new Point(600, 400);
            back.AutoSize = true;
            back.MouseClick += Back_MouseClick;
            gridPanel.Controls.Add(back);
        }

        private void ShowWinner()
        {
            string winner = Tournament.Tree.Root.Data;
            MessageBox.Show($"Победителем стал - {winner}");
        }

        private void Back_MouseClick(object? sender, MouseEventArgs e)
        {
            tournamentForm.Show();
            this.Close();
        }

        public void InsertPlayersInGrid(Node<string> node, int y)
        {
            var player = new Button();
            player.Location = new Point(50 + 100 * node.Height, y);
            player.Text = node.Data;
            player.Name = $"button{node.NodeId}";

            gridPanel.Controls.Add(player);

            if (node.Left != null)
            {
                InsertPlayersInGrid(node.Left, (int)node.Left.NodeId * 50 - 50 / node.Height);
            }
            if (node.Right != null)
            {
                InsertPlayersInGrid(node.Right, (int)node.Right.NodeId * 50 - 50 / node.Height);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            tournamentForm.Show();
        }
    }
}
