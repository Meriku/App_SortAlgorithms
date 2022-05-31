using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class QuickSort : BaseSort
    {
        /// Быстрая сортировка

        /// Время выполнения:
        /// В лучшем случае – О(nlog n)
        /// В худшем случае – О(n^2) 

        public QuickSort(int[] array)
        {
            MaxItems = 100000;
            Items = array.ToArray();
        }

        protected override void MakeSort()
        {
            QSort(0, Items.Length - 1);
        }

        private void QSort(int left, int right)
        {
            if (left >= right) 
            {
                return;
            }

            var pivot = Sorting(left, right); // Опорный элемент
            QSort(left, pivot - 1);
            QSort(pivot + 1, right);
                
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            for (int i = left; i <= right; i++)
            {
                if (Items[i] < Items[right])
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }

            Swap(pointer, right);
            return pointer;
        }
    }
}
