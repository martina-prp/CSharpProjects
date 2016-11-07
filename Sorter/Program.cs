using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            Console.WriteLine("Enter array elements!");
            var array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Enter Sort type (selection, bubble or linq): ");
            SortType sortType = SortType.Default;
            switch(Console.ReadLine())
            {
                case "selection":
                    sortType = SortType.Selection;
                    break;
                case "bubble":
                    sortType = SortType.Bubble;
                    break;
                case "linq":
                    sortType = SortType.Linq;
                    break;
                default:
                    Console.WriteLine("Invalid sort type!");
                    break;
            }

            Factory factory = new Factory();
            Sorter executeSorter = factory.Create(array, logger, sortType);
            
            int[] sortResult = executeSorter.Sorting();
            logger.WriteLine("Sort result: " + String.Join(",", sortResult));
        }
    }
}
