using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Abstraction
    {
        public abstract class Shape
        {
            // Abstract method to calculate area
            public abstract double CalculateArea();
        }

        // Concrete class representing a circle
        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            // Implementation of CalculateArea method for Circle
            public override double CalculateArea()
            {
                return Math.PI * radius * radius;
            }
        }

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Circle circle = new Circle(5);
        //        Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        //    }
        //}
    }
}
