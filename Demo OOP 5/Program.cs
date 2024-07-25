using Demo_OOP_5.Abstraction;
using Demo_OOP_5.Operators_Overloading;
using Demo_OOP_5.Partial;
using Demo_OOP_5.Static;
namespace demooop5
{ 
    internal class Program
    {
        static void Main (string[] args)
        {
            #region Operators Overloading 
            Complex C1 = new Complex() {Real = 3, Imag = 5 };
            Console.WriteLine(C1);

            Complex C2 = new Complex() {Real = 10, Imag = 6 };
            Console.WriteLine(C2);
            
            Complex C3 = default; // Null 
            C3 = C1 + C2;
            Console.WriteLine(C3);

            Complex C4 = default; // Null
            C4 = C1 - C2;
            Console.WriteLine(C4);
            #endregion

            #region Abstraction

            //Shape shape = new Shape();
            //shape.CalcArea();


            Rectangle rectangle = new Rectangle();
            rectangle.Dim1 = 10;
            rectangle.Dim2 = 20;
            decimal RectAngle = rectangle.CalcArea();
            Console.WriteLine (RectAngle);



            Square square = new Square(12);
            decimal squareArea = square.CalcArea();
            Console.WriteLine($"{squareArea}");

            decimal squrPremeter = square.Perimeter();
            Console.WriteLine(square.premetere);

            #endregion

            #region Static


            // before make CmToInch to static : 
            Utility U1 = new Utility(10 ,20);
            Console.WriteLine(U1.ToString());

            //Console.WriteLine(U1.CmToInch(254));


            Utility U2 = new Utility(100, 200);
            //Console.WriteLine(U2.CmToInch(254));


            // after make CmToInch to static : 

            Utility.CmToInch(1000);
            #endregion

            #region Partial
            Employee employee = new Employee() { Id= 1 , Name = "hesham" , age = 26};
            employee.Print();


            #endregion

        }
    }
}