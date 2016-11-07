using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int PerformOperation(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1!");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2!");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation!");
            string op = Console.ReadLine();
            OperationType operation = OperationType.Default;

            switch (op)
            {
                case "+":
                    operation = OperationType.Addition;
                    break;
                case "-":
                    operation = OperationType.Substract;
                    break;
                case "*":
                    operation = OperationType.Multiply;
                    break;
                default:
                    Console.WriteLine("Invalid Operation!");
                    break;
            }
            Factory factory = new Factory();
            var del = factory.Create(operation);
            Console.WriteLine("Operation result = {0}", del(num1, num2));
        }
    }
}
