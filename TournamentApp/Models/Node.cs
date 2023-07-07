using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp.Models
{
    public class Node<T> : IComparable
    {
        public float NodeId { get; private set; }
        public T Data { get; set; }
        public bool Victory = false;
        public Node<T> Left;
        public Node<T> Right;
        public int Height = 0;

        public Node(float nodeId, T player)
        {
            Data = player;
            NodeId = nodeId;
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return NodeId.CompareTo(item.NodeId);
            }
            else
            {
                throw new ArgumentException("Несовпадение типов.");
            }
        }
        public void Add(float index, T playerId)
        {
            Node<T> node = new Node<T>(index, playerId);

            if (index.CompareTo(NodeId) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(index, playerId);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(index, playerId);
                }
            }
            UpdateHeight(this);
            Balance(this);
        }
        private int GetHeight<Tm>(Node<Tm> node)
        {
            return node == null ? -1 : node.Height;
        }
        private void UpdateHeight<Tm>(Node<Tm> node)
        {
            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
        }
        private int GetBalance<Tm>(Node<Tm> node)
        {
            return node == null ? 0 : GetHeight(node.Right) - GetHeight(node.Left);

        }
        private void Swap<Tm>(Node<Tm> node_1, Node<Tm> node_2)
        {
            float key_1 = node_1.NodeId;
            node_1.NodeId = node_2.NodeId;
            node_2.NodeId = key_1;
            Tm value_1 = node_1.Data;
            node_1.Data = node_2.Data;
            node_2.Data = value_1;
        }
        private void RightRotate<Tm>(Node<Tm> node)
        {
            Swap(node, node.Left);
            Node<Tm> buffer = node.Right;
            node.Right = node.Left;
            node.Left = node.Right.Left;
            node.Right.Left = node.Right.Right;
            node.Right.Right = buffer;
            UpdateHeight(node.Right);
            UpdateHeight(node);
        }
        private void LeftRotate<Tm>(Node<Tm> node)
        {
            Swap(node, node.Right);
            Node<Tm> buffer = node.Left;
            node.Left = node.Right;
            node.Right = node.Left.Right;
            node.Right.Left = node.Right.Right;
            node.Left.Right = node.Left.Left;
            node.Left.Left = buffer;
            UpdateHeight(node.Left);
            UpdateHeight(node);
        }
        private void Balance<Tm>(Node<Tm> node)
        {
            int balance = GetBalance(node);
            if (balance == -2)
            {
                if (GetBalance(node.Left) == 1)
                {
                    LeftRotate(node.Left);
                }
                RightRotate(node);
            }
            else if (balance == 2)
            {
                if (GetBalance(node.Right) == -1)
                {
                    RightRotate(node.Right);
                }
                LeftRotate(node);
            }
        }
    }
}
