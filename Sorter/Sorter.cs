using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    abstract class Sorter
    {
        protected int[] Array { get; set; }
        protected ILogger ILogger { get; set; }
        protected SortType sortType;

        public Sorter(int[] arr, ILogger logger)
        {
            ILogger = logger;
            this.Array = new int[arr.Length]; 
            for (int i = 0; i < arr.Length; i++)
            {
                this.Array[i] = arr[i];
            }
        }

        abstract public int[] Sorting();
    }
}
