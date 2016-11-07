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

        }

        public override int[] SorterMethod()
        {
            var sorted = this.Array.Select(element => element).ToArray();
            return sorted.OrderBy(element => element).ToArray();
        }
    }
}
