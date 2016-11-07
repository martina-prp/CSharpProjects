using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Factory
    {
        public Sorter Create(int[] array, ILogger logger, SortType sortType)
        {
            if (sortType == SortType.Selection)
            {
                return new SelectionSort(array, logger);
            }
            
            if (sortType == SortType.Bubble)
            {
                return new BubbleSort(array, logger);
            }

            if (sortType == SortType.Linq)
            {
                return new LinqSort(array, logger);
            }

            return null;
        }
    }
}
