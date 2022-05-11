using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.DataStructure
{
    public class Tree
    {
        public Node Root { get; set; }

        public int Count { get; set; }

        public Tree(int[] array) 
        {
            foreach (var item in array)
            {
                Add(item);
            }
        }

        public void Add(int data)
        {
            var node = new Node(data);

            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Root.Add(node);
            Count++;
        }

        public int[] Inorder()
        {
            if (Root == null)
            {
                return null;
            }
            else
            {
                return Inorder(Root);
            }
        }

        private int[] Inorder(Node node)
        {
            var list = new List<int>();

            if (node.Left != null)
            {
                list.AddRange(Inorder(node.Left));
            }

            list.Add(node.Data);

            if (node.Right != null)
            {
                list.AddRange(Inorder(node.Right));
            }

            return list.ToArray();
        }

    }

}
