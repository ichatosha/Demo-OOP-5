using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_5.Abstraction
{
    internal abstract class Shape
    {

        public decimal Dim1 { get; set; }
        public decimal Dim2 { get; set; }


        public abstract decimal CalcArea();

        public abstract decimal Perimeter
        {
            get;
        }
    }
}
