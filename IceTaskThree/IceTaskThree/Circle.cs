using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTaskThree
{
    // Circle class inherits Shape and implements ICalculateArea
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        // Implement CalculateArea method
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Override Display method
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
        }
    }
}
