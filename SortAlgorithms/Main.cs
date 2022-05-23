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
        Label arrayLabel = new Label();

        private int ArrayLenght = 500;

        private List<SortAlgorithmAndLabel<ISort>> sortAlgorithmAndLabels = new List<SortAlgorithmAndLabel<ISort>>();

        public Main()
        {
            InitializeComponent();
        }

        private void buttonGenerateArray_Click(object sender, EventArgs e)
        {
   
            if (SortVisualization.labels.Count() == 0)
            {
                array.Items = GetArray(ArrayLenght);
                arrayLabel = SortVisualization.DrawLabel($"Случайный массив: {array}");
                Controls.Add(arrayLabel);
            }
            else
            {
                array.Items = GetArray(ArrayLenght);
                arrayLabel.Invoke((Action)delegate { arrayLabel.Text = $"Случайный массив: {array}"; });

                foreach (var sortAlgor in sortAlgorithmAndLabels)
                {
                    Controls.Remove(sortAlgor.Label);
                    if (SortVisualization.labels.Contains(sortAlgor.Label))
                    {
                        SortVisualization.labels.Remove(sortAlgor.Label);
                    }        
                }

                sortAlgorithmAndLabels.Clear();
            }
        }

        private void buttonSortArray_Click(object sender, EventArgs e)
        {
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new BubbleSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new CocktailSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new SelectionSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new GnomeSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new TreeSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new HeapSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new InsertionSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new ShellSort(array.Items)));
            sortAlgorithmAndLabels.Add(new SortAlgorithmAndLabel<ISort>(new RadixSort(array.Items)));

            foreach (var sortAlgor in sortAlgorithmAndLabels)
            {
                Controls.Add(sortAlgor.Label);
            }

            foreach (var sortAlgor in sortAlgorithmAndLabels)
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

                            Thread.Sleep(600);
                        }
                        // После завершения сортировки выводим результат 
                        var place = sortAlgorithmAndLabels.Where(x => x.IsSorted).Count();
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

        private int[] GetArray(int count)
        {
            var result = new int[count];
            for (int i = 0; i < count; i++)
            {
                var rnd = new Random(i+DateTime.Now.Millisecond);
                result[i] = rnd.Next(0, 101);
            }
            return result;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
