using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTaskThree
{
    // Rectangle class inherits Shape and implements ICalculateArea
    class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(double length, double width) : base("Rectangle")
        {
            Length = length;
            Width = width;
        }

        // Implement CalculateArea method
        public double CalculateArea()
        {
            return Length * Width;
        }

        // Override Display method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Length: {Length}, Width: {Width}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
}