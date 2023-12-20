using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Abstract base class for shapes
    public abstract class Shape
    {
        public abstract double Area();
    }

    //Concrete implementation of Shape for Rectangle
    public class Rectangle : Shape
    {
        private readonly double with;
        private readonly double height;
        public Rectangle(double with, double height)
        {
            this.with = with;
            this.height = height;
        }

        public override double Area()
        {
            return with * height;
        }
    }

    //Concrete implementation of Shape for Circle
    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * radius;
        }
    }

    //Function to compute to total area of shapes without modifying existing code
    public class AreaCalculator
    {
        public double CalculateTotalArea(List<Shape> shapes)
        {
            double totalArea = 0;
            foreach(Shape shape in shapes)
            {
                totalArea += shape.Area();
            }
            return totalArea;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Shape> shapes = new List<Shape>
    //        {
    //            new Rectangle(4,5),
    //            new Circle(5)
    //        };

    //        AreaCalculator areaCalculator = new AreaCalculator();
    //        double calculator = areaCalculator.CalculateTotalArea(shapes);

    //        Console.WriteLine($"Shape of {shapes[0]}:");
    //        Console.WriteLine($"Shape of {shapes[1]}:");
    //        Console.WriteLine($"Total area of shapes: {calculator}");
    //    }
    //}

}
