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
        BaseSort array = new BaseSort();

        private int ArrayLenght = 500;

        private List<SortAlgorithmAndLabel<ISort>> sortAlgorithmAndLabels = new List<SortAlgorithmAndLabel<ISort>>();

        public Main()
        {
            InitializeComponent();
        }

        private void buttonGenerateArray_Click(object sender, EventArgs e)
        {
            array.SetNewArray(ArrayLenght);
            if (SortVisualization.Array is null)
            {
                SortVisualization.DrawArray($"Array: {array}");
                Controls.Add(SortVisualization.Array);
            }
            else 
            {
                SortVisualization.DrawArray($"Array: {array}");
            }
                 
            foreach (var sortAlgor in sortAlgorithmAndLabels)
            {
                Controls.Remove(sortAlgor.Label);
                Controls.Remove(sortAlgor.CheckBox);
                SortVisualization.Clear();   
            }
            sortAlgorithmAndLabels.Clear();
                   
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new BubbleSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new CocktailSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new SelectionSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new GnomeSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new InsertionSort(array.Items)));        
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new TreeSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new HeapSort(array.Items)));                   
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new ShellSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new RadixSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new MergeSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new QuickSort(array.Items)));
            
            foreach (var sortAlgor in sortAlgorithmAndLabels)
            {
                Controls.Add(sortAlgor.Label);
                Controls.Add(sortAlgor.CheckBox);
            }
        }

        private void buttonSortArray_Click(object sender, EventArgs e)
        {     
            foreach (var sortAlgor in sortAlgorithmAndLabels.Where(x => x.CheckBox.Checked).Where(x => !x.IsSorted))
            {
                Task.Run(() =>
                {
                    Task.Run(() => 
                    {
                        var temptext = sortAlgor.Label.Text;    // Сохраняем название алгоритма

                        sortAlgor.Label.Invoke((Action)delegate { sortAlgor.Label.Text += $" Sorting"; });

                        // Асинхронно пишем ., .., ... пока сортируем массив
                        while (!sortAlgor.IsSorted)
                        {
                            if (sortAlgor.Label.Text.Contains("..."))
                            {
                                sortAlgor.Label.Invoke((Action)delegate { sortAlgor.Label.Text = $"{temptext} Sorting"; });
                            }
                            else
                            {
                                sortAlgor.Label.Invoke((Action)delegate { sortAlgor.Label.Text += $"."; });
                            }

                            Thread.Sleep(500);
                        }
                        // После завершения сортировки выводим результат 
                        //var place = sortAlgorithmAndLabels.Where(x => x.IsSorted).Count();
                        var place = sortAlgorithmAndLabels.Where(x => x.IsSorted).Where(x => x.Time < sortAlgor.Time).Count() + 1;
                        sortAlgor.Label.Invoke((Action)delegate { sortAlgor.Label.Text = $"#{place}. {temptext} Time: {sortAlgor.Time} Swap count: {sortAlgor.SwapCount}\nArray: {sortAlgor}"; });
                    }); 
                   
                    // Сортируем асинхронно 
                    sortAlgor.Sort();
                   
                });

            }
        }

        private void trackBarArrayLenght_ValueChanged(object sender, EventArgs e)
        {
            labelArrayLenght.Text = "Длина массива: " + trackBarArrayLenght.Value.ToString();
            ArrayLenght = trackBarArrayLenght.Value;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void labelArrayLenght_Click(object sender, EventArgs e)
        {

        }
    }
}
