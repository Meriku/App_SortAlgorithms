using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class BaseSort
    {
        public int[] Items;
        public int SwapCount { get; protected set; } = 0;

        public bool IsSorted = false;


        protected void Swap (int index1, int index2)
        {
            (Items[index1], Items[index2]) = (Items[index2], Items[index1]);
            SwapCount++;
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
