using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len, x, y;
            Console.WriteLine("Enter array dimension:");
            while (!int.TryParse(Console.ReadLine(), out len) || len < 0)
            {
                Console.WriteLine("Enter array dimension as positivie Integer:");
            }
            int[][] array = InitialiseMatrix(len);
            Console.WriteLine("Enter coordinates:");
            string line = null;
            string[] coordinates;

            do
            {
                line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                coordinates = line.Split(' ');

                while (!int.TryParse(coordinates[0], out x) || !int.TryParse(coordinates[1], out y))
                {
                    Console.WriteLine("Enter correct coordinates!");
                    line = Console.ReadLine();
                    coordinates = line.Split(' ');
                }

                if ((x >= 0 && x <= len) && (y >= 0 && y <= len))
                {
                    array[x][y] += 1;
                    PrintMatrix(array);
                }
                else
                {
                    Console.WriteLine("The entered coordinates are out of the array boundaries!");
                }
            } while (true);
        }

        static int[][] InitialiseMatrix(int len)
        {
            int[][] array = new int[len][];

            int number = 1;
            for (int i = 0; i < len; i++)
            {
                array[i] = new int[len];
                for (int j = 0; j < len; j++)
                {
                    array[i][j] = number++;
                }
            }
            return array;
        }

        static void PrintMatrix(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
