using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public Complex(int real, int img)
        {
            this.Real = real;
            this.Img = img;
        }

        public override string ToString()
        {
            return String.Format("{0} + {1}i", this.Real, this.Img);
        }

        public static Complex operator +(Complex comp1, Complex comp2)
        {
            return (new Complex((comp1.Real + comp2.Real), (comp1.Img + comp2.Img)));
        }

        public static Complex operator -(Complex comp1, Complex comp2)
        {
            return (new Complex((comp1.Real - comp2.Real), (comp1.Img - comp2.Img)));
        }
    }
}
