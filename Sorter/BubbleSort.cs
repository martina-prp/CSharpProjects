using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class BubbleSort : Sorter
    {
        private SortType sortType;
        public SortType SortType
        {
            get
            {
                return this.sortType;
            }

            protected set
            {
                this.sortType = SortType.Bubble;
            }
        }

        public BubbleSort(int[] arr, ILogger logger) : base(arr, logger)
        {

        }

        public override int[] SorterMethod()
        {
            int[] sorted = new int[this.Array.Length];
            for (int i = 0; i < this.Array.Length; i++)
            {
                sorted[i] = this.Array[i];
            }

            bool flag = true;
            for (int i = 1; (i <= (sorted.Length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (sorted.Length - 1); j++)
                {
                    if (sorted[j + 1] < sorted[j])
                    {
                        int temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return sorted;
        }
    }
}
