using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_5.Sealed
{
    internal class Parent
    {
        private  int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Iam parent");
        }
    }

    class Child : Parent
    {

        public sealed override int Salary {   
            get => base.Salary;
            set => base.Salary = value < 5000 ? 5000 : value; }

        // sealed method => last class to override 
        public sealed override void Print()
        {
            Console.WriteLine("iam child");
        }

    }

    class GrandChild : Child
    {
        public override void Print()
        {
            Console.WriteLine("hello grand child"); 
        }
    }
}
