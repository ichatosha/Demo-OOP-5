using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_5.Abstraction
{
    internal class Square : Shape
    {
        public override decimal Perimeter => Dim1 * 4;

        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }

        public Square(decimal Dim) 
        {
            Dim1 = Dim2 = Dim;
        }

        
    }
}
