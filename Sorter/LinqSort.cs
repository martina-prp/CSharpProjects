using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class LinqSort : Sorter
    {
        public LinqSort(int[] arr, ILogger logger) : base(arr, logger)
        {
            this.sortType = SortType.Linq;
        }

        public override int[] Sorting()
        {
            var sorted = this.Array.Select(element => element).ToArray();
            return sorted.OrderBy(element => element).ToArray();
        }
    }
}
