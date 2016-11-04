using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            int real, img;
            // It is an array of two complex numbers for the puprose of the task.
            Complex[] complexArray = new Complex[2];
            Console.WriteLine("Enter two complex numbers!");
            for (int i=0; i<2; i++)
            {
                Console.WriteLine("Enter complex number by using space!");
                string[] line = Console.ReadLine().Split(' ');
                while (!int.TryParse(line[0], out real) || !int.TryParse(line[1], out img))
                {
                    Console.WriteLine("Enter valid values!");
                    line = Console.ReadLine().Split(' ');
                }
                complexArray[i] = new Complex(real, img);
            }
            Console.WriteLine("Enter operation (add or sub):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "add":
                    Console.WriteLine("Result of addition: {0}", (complexArray[0] + complexArray[1]));
                    break;
                case "sub":
                    Console.WriteLine("Result of substraction: {0}", (complexArray[0] - complexArray[1]));
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }
}
