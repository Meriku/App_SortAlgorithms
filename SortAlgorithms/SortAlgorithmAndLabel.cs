using SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    internal class SortAlgorithmAndLabel
    {
        public Label Label { get; private set; }
        public double Time;
        public int SwapCount;
        public bool IsSorted = false;

        private BubbleSort bubbleSort;
        private CocktailSort cocktailSort;
        private InsertionSort insertionSort;
        private ShellSort shellSort;
        private TreeSort treeSort;
        private HeapSort heapSort;
        private SelectionSort selectionSort;


        public SortAlgorithmAndLabel(BubbleSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Bubble Sort:");
            bubbleSort = sortalgorithm;                     
        }
        public SortAlgorithmAndLabel (CocktailSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Cocktail Sort:");
            cocktailSort = sortalgorithm;
        }
        public SortAlgorithmAndLabel(InsertionSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Insertion Sort:");
            insertionSort = sortalgorithm;
        }
        public SortAlgorithmAndLabel(ShellSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Shell Sort:");
            shellSort = sortalgorithm;
        }
        public SortAlgorithmAndLabel(TreeSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Tree Sort:");
            treeSort = sortalgorithm;
        }
        public SortAlgorithmAndLabel(HeapSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Heap Sort:");
            heapSort = sortalgorithm;
        }
        public SortAlgorithmAndLabel(SelectionSort sortalgorithm)
        {
            Label = SortVisualization.DrawLabel("Selection Sort:");
            selectionSort = sortalgorithm;
        }


        public void Sort()
        {
            if (bubbleSort != null)
            {
                bubbleSort.Sort();
                Time = bubbleSort.Time;
                SwapCount = bubbleSort.SwapCount;
                IsSorted = true;
            }
            if (cocktailSort != null)
            {
                cocktailSort.Sort();
                Time = cocktailSort.Time;
                SwapCount = cocktailSort.SwapCount;
                IsSorted = true;
            }
            if (insertionSort != null)
            {
                insertionSort.Sort();
                Time = insertionSort.Time;
                SwapCount = insertionSort.SwapCount;
                IsSorted = true;
            }
            if (shellSort != null)
            {
                shellSort.Sort();
                Time = shellSort.Time;
                SwapCount = shellSort.SwapCount;
                IsSorted = true;
            }
            if (treeSort != null)
            {
                treeSort.Sort();
                Time = treeSort.Time;
                SwapCount = treeSort.SwapCount;
                IsSorted = true;
            }
            if (heapSort != null)
            {
                heapSort.Sort();
                Time = heapSort.Time;
                SwapCount = heapSort.SwapCount;
                IsSorted = true;
            }
            if (selectionSort != null)
            {
                selectionSort.Sort();
                Time = selectionSort.Time;
                SwapCount = selectionSort.SwapCount;
                IsSorted = true;
            }
        }

        public override string ToString()
        {

            if (bubbleSort != null)
            {
                return bubbleSort.ToString();
            }
            if (cocktailSort != null)
            {
                return cocktailSort.ToString();
            }
            if (insertionSort != null)
            {
                return insertionSort.ToString();
            }
            if (shellSort != null)
            {
                return shellSort.ToString();
            }
            if (treeSort != null)
            {
                return treeSort.ToString();
            }
            if (heapSort != null)
            {
                return heapSort.ToString();
            }
            if (selectionSort != null)
            {
                return selectionSort.ToString();
            }

            return "";
        }


    }
}
