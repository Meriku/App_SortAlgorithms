using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class InsertionSort : BaseSort
    {
        /// Сортировка Вставкой 

        /// Время выполнения:
        /// В лучшем случае – О(n)
        /// В среднем случае – О(nlog n)
        /// В худшем случае – О(n^2) 
    
        public InsertionSort(int[] array)
        {
            MaxItems = 20000;
            Items = array.ToArray();
        }

        protected override void MakeSort()
        {
            for (int i = 1; i < Items.Length; i++)
            {
                var temp = Items[i];
                var j = i;
                while (j > 0 && temp < Items[j - 1])
                {
                    Items[j] = Items[j - 1];
                    SwapCount++;
                    j--;
                }
                Items[j] = temp;
            }
        }





    }
}
