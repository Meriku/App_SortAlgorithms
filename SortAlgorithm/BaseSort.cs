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
        public int[] Items { get; protected set; }
        public int SwapCount { get; protected set; } = 0;

        private Stopwatch timer = new Stopwatch();

        protected int MaxItems { set; get; }

        int ISort.SwapCount { get => SwapCount; }
        double ISort.Time { get => timer.Elapsed.TotalMilliseconds; }
        int ISort.MaxItems { get => MaxItems; }
        int[] ISort.Items { get => Items; }

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

        public void SetNewArray(int count)
        {
            var result = new int[count];
            for (int i = 0; i < count; i++)
            {
                var rnd = new Random(i + DateTime.Now.Millisecond);
                result[i] = rnd.Next(0, 101);
            }
            Items = result;
        }

    }
}
