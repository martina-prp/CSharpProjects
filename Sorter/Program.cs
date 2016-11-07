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
            //switch(Console.ReadLine().ToLower())
            //{
                    Sorter selectionSorter = new SelectionSort(array, logger);
                    //if ()
                    int[] selectionSortResult = selectionSorter.SorterMethod();
                    logger.WriteLine("Selection Sort result: " + String.Join(",", selectionSortResult));
                    //break;
            //}
            

            

            Sorter bubbleSorter = new BubbleSort(array, logger);
            int[] bubbleSortResult = bubbleSorter.SorterMethod();
            logger.WriteLine("Bubble Sort result: " + String.Join(",", bubbleSortResult));

            Sorter linqSorter = new LinqSort(array, logger);
            int[] linqSortResult = linqSorter.SorterMethod();
            logger.WriteLine("LINQ Sort result: " + String.Join(", ", linqSortResult));
        }
    }
}
