using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Factory
    {
        public PerformOperation Create(OperationType operation)
        {
            PerformOperation handler = null;
            if (operation == OperationType.Addition)
            {
                handler = Addition;
            }

            if (operation == OperationType.Substract)
            {
                handler = Substract;
            }

            if (operation == OperationType.Multiply)
            {
                handler = Multiply;
            }

            return handler;
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int Substract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
