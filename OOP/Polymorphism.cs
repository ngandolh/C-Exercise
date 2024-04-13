using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Base class
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    // Derived class
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class ProgramPolymorphism
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Shape();
            Shape shape2 = new Circle();

            shape1.Draw(); // Output: Drawing a shape
            shape2.Draw(); // Output: Drawing a circle
        }
    }
}
