using SortAlgorithm;
using SortAlgorithm.DataStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Main : Form
    {
        SortVisualization visualization = new SortVisualization();
        List<Label> labels = new List<Label>();
        List<BaseSort> sorts = new List<BaseSort>();

        BaseSort array = new BaseSort();
        BubbleSort bubbleSort;
        CocktailSort cocktailSort;
        InsertionSort insertionSort;
        ShellSort shellSort;
        TreeSort treeSort;
        HeapSort heapSort;



        private int ArrayLenght = 500;
        private Random rnd = new Random();


        public Main()
        {
            InitializeComponent();
        }

        private void buttonGenerateArray_Click(object sender, EventArgs e)
        {
            if (visualization.labels.Count <= 1)
            // Первый вызов
            {
                array.Items = GetArray(ArrayLenght);
                var label = visualization.DrawLabel($"Случайный массив: {array}");
                Controls.Add(label);
            }
            else
            {
            // Последующие вызовы
                foreach (var lab in visualization.labels)
                {
                    Controls.Remove(lab);
                }
                visualization.labels.Clear();

                array.Items = GetArray(ArrayLenght);
                var label = visualization.DrawLabel($"Случайный массив: {array}");
                Controls.Add(label);
            }
       
        }

        private void buttonSortArray_Click(object sender, EventArgs e)
        {
            sorts.Clear();

            bubbleSort = new BubbleSort(array.Items);
            cocktailSort = new CocktailSort(array.Items);
            insertionSort = new InsertionSort(array.Items);
            shellSort = new ShellSort(array.Items);
            treeSort = new TreeSort(array.Items);
            heapSort = new HeapSort(array.Items);

            sorts.AddRange( new List<BaseSort>(){ bubbleSort, cocktailSort, insertionSort, shellSort, treeSort, heapSort } );

            var bubbleSortLabel = visualization.DrawLabel("Bubble Sort Time:");
            var cocktailSortLabel = visualization.DrawLabel("Cocktail Sort Time:");
            var insertionSortLabel = visualization.DrawLabel("Insertion Sort Time:");
            var shellSortLabel = visualization.DrawLabel("Shell Sort Time:");
            var treeSortLabel = visualization.DrawLabel("Tree Sort Time:");
            var heapSortLabel = visualization.DrawLabel("Heap Sort Time:");


            Controls.Add(cocktailSortLabel);
            Controls.Add(bubbleSortLabel);
            Controls.Add(insertionSortLabel);
            Controls.Add(shellSortLabel);
            Controls.Add(treeSortLabel);
            Controls.Add(heapSortLabel);



            Task.Run(() => { 
                            bubbleSort.Sort();
                            var place = sorts.Where(x => x.IsSorted).Count(); 
                            bubbleSortLabel.Invoke((Action)delegate { bubbleSortLabel.Text = $"{place}. Bubble Sort Time: {bubbleSort.Time} Swap count: {bubbleSort.SwapCount}\nBubble Sort: {bubbleSort}"; });
            });

            Task.Run(() => { 
                            cocktailSort.Sort();
                            var place = sorts.Where(x => x.IsSorted).Count();
                            cocktailSortLabel.Invoke((Action)delegate { cocktailSortLabel.Text = $"{place}. Cocktail Sort Time: {cocktailSort.Time} Swap count: {cocktailSort.SwapCount}\nCocktail Sort: {cocktailSort}"; });
            });


            Task.Run(() => {
                            insertionSort.Sort();
                            var place = sorts.Where(x => x.IsSorted).Count();
                            insertionSortLabel.Invoke((Action)delegate { insertionSortLabel.Text = $"{place}. Insertion Sort Time: {insertionSort.Time} Swap count: {insertionSort.SwapCount}\nInsertion Sort: {insertionSort}"; });
            });


            Task.Run(() => {
                            shellSort.Sort();
                            var place = sorts.Where(x => x.IsSorted).Count();
                            shellSortLabel.Invoke((Action)delegate { shellSortLabel.Text = $"{place}. Shell Sort Time: {shellSort.Time} Swap count: {shellSort.SwapCount}\nShell Sort: {shellSort}"; });
            });


            Task.Run(() =>
            {
                            treeSort.Sort();
                            var place = sorts.Where(x => x.IsSorted).Count();
                            treeSortLabel.Invoke((Action)delegate { treeSortLabel.Text = $"{place}. Tree Sort Time: {treeSort.Time} Swap count: {treeSort.SwapCount}\nTree Sort: {treeSort}"; });
            });

            Task.Run(() => {
                            heapSort.Sort();
                            var place = sorts.Where(x => x.IsSorted).Count();
                            heapSortLabel.Invoke((Action)delegate { heapSortLabel.Text = $"{place}. Heap Sort Time: {heapSort.Time} Swap count: {heapSort.SwapCount}\nHeap Sort: {heapSort}"; });
            });
        }



        private void trackBarArrayLenght_ValueChanged(object sender, EventArgs e)
        {
            labelArrayLenght.Text = "Длина массива: " + trackBarArrayLenght.Value.ToString();
            ArrayLenght = trackBarArrayLenght.Value;
        }

        private int[] GetArray(int count)
        {
            var result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = rnd.Next(0, 101);
            }
            return result;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
