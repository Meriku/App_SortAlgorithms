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

        private Stopwatch timer = new Stopwatch();
        public double Time => timer.Elapsed.TotalMilliseconds;


        private Tree tree;
        private int[] Array;

        public TreeSort(int[] array)
        {
            Array = array;
        }

        public void Sort()
        {
            timer.Restart();

            tree = new Tree(Array);
            Items = tree.Inorder();

            IsSorted = true;
            timer.Stop();

        }





    }
}
