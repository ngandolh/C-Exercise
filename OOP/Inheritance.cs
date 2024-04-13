using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Some sound");
        }
    }

    // Derived class inheriting from Animal
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Top-level new instance
        //    Animal animal = new Dog();
        //    animal.Sound(); // Output: Bark
        //    Animal animal2 = new Animal();
        //    animal2.Sound(); //Some sound
        //}
    }
}

