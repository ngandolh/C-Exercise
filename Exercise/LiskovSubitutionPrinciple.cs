using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Base class
    public class Shape2
    {
        public virtual double Area2()
        {
            return 0;
        }
    }

    //Subclass Rectangle
    public class Rectangle2 : Shape2
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle2(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area2()
        {
            return width * height;
        }
    }

    //Subclass Square
    public class Square2 : Shape2
    {
        public double SideLength { get; set; }
        public Square2(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area2()
        {
            return SideLength * SideLength;
        }
    }

    //Function using Shape
    public class AreaCalculator2
    {
        public double CalculatorArea(Shape2 shape)
        {
            return shape.Area2();
        }
    }
    //public class LiskovSubitutionPrinciple
    //{
    //    static void Main(string[] args)
    //    {
    //        Shape2 rectangle = new Rectangle2(5, 10);
    //        Shape2 square = new Square2(7);

    //        AreaCalculator2 total = new AreaCalculator2();

    //        Console.WriteLine($"Area of Rectangle: {total.CalculatorArea(rectangle)}"); // Output: 50
    //        Console.WriteLine($"Area of Square: {total.CalculatorArea(square)}"); // Output: 49
    //    }
    //}

}
