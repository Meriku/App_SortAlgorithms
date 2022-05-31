using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public interface ISort
    {
        void Sort();

        int SwapCount { get; }
        double Time { get; }
        int MaxItems { get; }
        int[] Items { get; }
    }
}
