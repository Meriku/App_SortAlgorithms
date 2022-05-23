using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class BaseSort : ISort
    {
        public int[] Items;
        public int SwapCount { get; protected set; } = 0;

        private Stopwatch timer = new Stopwatch();
        public double Time => timer.Elapsed.TotalMilliseconds;

        int ISort.SwapCount { get => SwapCount; }
        double ISort.Time { get => Time; }

        protected void Swap (int index1, int index2)
        {
            (Items[index1], Items[index2]) = (Items[index2], Items[index1]);
            SwapCount++;
        }
        
        public void Sort()
        {
            timer.Restart();

            MakeSort();

            timer.Stop();
        }


        protected virtual void MakeSort()
        {
            Items = Items.OrderBy(x => x).ToArray();
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < Items.Length; i++)
            {
                if (i == Items.Length - 1)
                {
                    result.Append(Items[i]);
                }
                else
                {
                    result.Append(Items[i] + ", ");
                }

                if (i > 20)
                {
                    result.Append("... ");
                    result.Append(Items.Last());
                    break;
                }

            }

            return result.ToString();
        }


    }
}
