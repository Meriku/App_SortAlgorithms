using SortAlgorithm.DataStructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class TreeSort : BaseSort
    {
        private Tree tree;
        private int[] Array;

        public TreeSort(int[] array)
        {
            Items = array;
            MaxItems = 50000;
            Array = array.ToArray();
        }

        protected override void MakeSort()
        {
            tree = new Tree(Array);
            Items = tree.Inorder();
        }


    }
}
