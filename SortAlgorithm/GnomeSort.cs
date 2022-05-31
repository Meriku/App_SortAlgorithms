using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class GnomeSort : BaseSort
    {

        /// Гномья Сортировка 

        /// Время выполнения:
        /// В лучшем случае – О(n)
        /// В худшем случае – О(n^2) 


        public GnomeSort(int[] array)
        {
            MaxItems = 20000;
            Items = array.ToArray();
        }

        protected override void MakeSort()
        {
            var i = 1;
            while (i < Items.Length)
            {
                if (i == 0 || Items[i - 1] <= Items[i])
                {
                    i++;
                }
                else
                {
                    Swap(i, i - 1);
                    i--;
                }
            }
        }




    }
}
