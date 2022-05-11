using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class CocktailSort : BaseSort
    {
        /// Шейкерная Сортировка 

        /// Время выполнения:
        /// В лучшем случае – О(n)
        /// В худшем случае – О(n^2) 

        private Stopwatch timer = new Stopwatch();
        public double Time => timer.Elapsed.TotalMilliseconds;

        public CocktailSort(int[] array)
        {
            Items = array;
        }

        public void Sort()
        {
            timer.Restart();
            
            int left = 0;                   // Крайний левый неотсортированый элемент
            int right = Items.Length - 1;   // Крайний правый неотсортированый элемент

            while (left < right)
            {
                for (int i = left; i < right; i++)
                // Движение слева направо 
                {
                    if (Items[i] > Items[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }
                right--; // Отсортировали крайний правый элемент

                for (int i = right; i > left; i--)
                // Движение справа налево
                {
                    if (Items[i] < Items[i - 1])
                    {
                        Swap(i, i - 1);
                    }
                }
                left++; // Отсортировали крайний левый элемент
            }
            IsSorted = true;
            timer.Stop();
        }
    }
}
