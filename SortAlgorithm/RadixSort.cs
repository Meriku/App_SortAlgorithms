using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class RadixSort : BaseSort
    {

        /// Поразрядная сортировка Radix sort LSD

        /// Время выполнения:
        /// Всегда – О(n * k/d)

        public RadixSort(int[] array)
        {
            MaxItems = 100000;
            Items = array.ToArray();
        }

        protected override void MakeSort()
        {
            var itemsList = Items.ToList();
            var groups = new List<List<int>>();
            // Группировка чисел по цифрам в разрядах

            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<int>());
            }

            int length = GetMaxLength();
            for (int step = 0; step < length; step++)
            // Количество проходов = наибольшему количеству разрядов (если наибольшее число 999 - три прохода соответственно)
            {
                // Распределение элементов по корзинам 
                foreach (var item in itemsList)
                {
                    var value = item % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);    
                    // Получаем число необходимого разряда 
                    // Из 567 получаем 5, 6 или 7 в зависимости от того 
                    // какой разряд сейчас сортируем (какой по счету это проход)
                }

                itemsList.Clear();
                // Сборка элементов
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        itemsList.Add(item);
                    }
                }
                // Очистка корзины
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
            Items = itemsList.ToArray();
        }

        private int GetMaxLength()
        {
            var length = 0;

            foreach (int item in Items)
            {
                var l = 0;
                if (item == 0)
                {
                    l = 1;
                }
                else
                {
                    l = Convert.ToInt32(Math.Floor(Math.Log10(item) + 1));
                }

                if (l > length)
                {
                    length = l;
                }
            }

            return length;
        }
    }
}
