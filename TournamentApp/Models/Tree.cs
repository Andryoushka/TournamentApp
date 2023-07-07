using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Models
{
    public class Tree<T>
    {
        public Node<T> Root;

        public void Add(float index, T playerId)
        {
            if (Root == null)
            {
                Root = new Node<T>(index, playerId);
                return;
            }
            Root.Add(index, playerId);
        }
    }
}
