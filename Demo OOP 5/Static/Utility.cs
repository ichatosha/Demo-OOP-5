using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_5.Static
{
    internal class Utility
    {
        public int  X { get; set; }

        public  int Y { get; set; }

        public Utility(int x ,int y)
        {
            X = x;
            Y = y;
        }

        public static double CmToInch(double Cm)
        {
            return Cm/2.54;
        }
    }
}
