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

        public CocktailSort(int[] array)
        {
            MaxItems = 20000;
            Items = array.ToArray();
        }

        protected override void MakeSort()
        {           
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
        }
    }
}
