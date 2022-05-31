using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class MergeSort : BaseSort
    {


        /// Сортировка слиянием Merge Sort 

        /// Время выполнения:
        /// Всегда – О(n logn)

        public MergeSort(int[] array)
        {
            MaxItems = 100000;
            Items = array.ToArray();
        }

        protected override void MakeSort()
        {
            Items = Sort(Items);
        }

        private int[] Sort(int[] items)
        {
            if (items.Length == 1)
            {
                return items;
            }

            var mid = items.Length / 2;
            // Середина массива

            var left = items.Take(mid).ToArray(); 
            // Левая часть массива (до середины)

            var right = items.Skip(mid).ToArray();
            // Правая часть массива 

            return Merge(Sort(left), Sort(right));
        }

        private int[] Merge(int[] left, int[] right)
        {
            var length = left.Length + right.Length;
            var leftPointer = 0;
            var rightPointer = 0;

            var result = new List<int>(length);
            for (var i = 0; i < length; i++)
            {
                if (leftPointer < left.Length && rightPointer < right.Length)
                // Защита от выхода за пределы коллекций 
                {
                    SwapCount++;
                    if (left[leftPointer] < right[rightPointer])
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    SwapCount++;
                    if (rightPointer < right.Length)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }

                }
            }

            return result.ToArray();

        }



    }

        


}






