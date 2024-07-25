using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_5.Abstraction
{
    internal class Rectangle : Shape
    {
        public override decimal Perimeter
        {
            get { return (Dim1 + Dim2) * 2; }
        }

        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }
    }
}
