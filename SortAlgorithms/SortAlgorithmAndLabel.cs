using SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    internal class SortAlgorithmAndLabel<T> where T : ISort
    {
        public Label Label { get; private set; }
        public double Time;
        public int SwapCount;
        public bool IsSorted = false;


        private T sortAlgorithm;

        public SortAlgorithmAndLabel(T sortalgorithm)
        {
            if (sortalgorithm == null)
            {
                throw new ArgumentNullException(nameof(sortalgorithm));
            }
            else
            {
                var sortType = sortalgorithm.GetType();
                Label = SortVisualization.DrawLabel(sortType.Name);
                sortAlgorithm = sortalgorithm;
            }
        }

        public void Sort()
        {
            sortAlgorithm.Sort();
            Time = sortAlgorithm.Time;
            SwapCount = sortAlgorithm.SwapCount;
            IsSorted = true;
        }

        public override string ToString()
        {
            return sortAlgorithm.ToString();
        }


    }
}
