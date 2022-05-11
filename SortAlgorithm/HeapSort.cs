using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class HeapSort : BaseSort
    {
        private Stopwatch timer = new Stopwatch();
        public double Time => timer.Elapsed.TotalMilliseconds;


        private Heap heap;
        private int[] Array;

        public HeapSort(int[] array)
        {
            Array = array;
        }

        public void Sort()
        {
            timer.Restart();

            heap = new Heap(Array);

            var result = new List<int>();
            foreach (var item in heap)
            {
                result.Add((int)item);
            }

            Items = result.ToArray();
            SwapCount = heap.SwapCounts;
            IsSorted = true;
            timer.Stop();

        }





    }
}
