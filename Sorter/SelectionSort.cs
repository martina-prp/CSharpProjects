using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class SelectionSort : Sorter
    {
        public SelectionSort(int[] arr, ILogger logger) : base(arr, logger)
        {
            this.sortType = SortType.Selection;
        }

        public override int[] Sorting()
        {
            int[] sorted = new int[this.Array.Length];
            for (int i = 0; i < this.Array.Length; i++)
            {
                sorted[i] = this.Array[i];
            }

            for (int i = 0; i < this.Array.Length; i++)
            {
                int min = sorted[i];
                int minIndex = i;
                for (int j = i; j < this.Array.Length; j++)
                {
                    if (min > sorted[j])
                    {
                        min = sorted[j];
                        minIndex = j;
                    }
                }
                int temp = sorted[i];
                sorted[i] = min;
                sorted[minIndex] = temp;
            }

            return sorted;
        }
    }
}
