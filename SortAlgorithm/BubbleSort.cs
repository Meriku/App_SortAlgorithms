using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class BubbleSort : BaseSort
    {
        /// Сортировка Пузырьком 

        /// Время выполнения:
        /// В лучшем случае – О(n)
        /// В худшем случае – О(n^2) 
        

        private Stopwatch timer = new Stopwatch();
        public double Time => timer.Elapsed.TotalMilliseconds;

        public BubbleSort(int[] array)
        {
            Items = array;
        }

        public void Sort()
        {
            timer.Restart();
            var count = Items.Length;

            for (int j = 0; j < count; j++) // Число проходов = длине массива
            // За каждый проход мы ставим одно максимальное число в конец
            {
                for (int i = 0; i < count - j - 1; i++)
                // Поскольку мы ставим максимальное число в конец
                // С каждым проходом мы проверяем на одно число в массиве меньше
                {
                    var a = Items[i];       // Левое число
                    var b = Items[i + 1];   // Правое число

                    if (a > b)
                    {
                        Swap(i, i + 1);
                    }
                }
            }
            IsSorted = true;
            timer.Stop();
        }







    }
}
