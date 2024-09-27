using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Last
{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("This is parent class");
        }
    }
    class Dog : Animal
    {
        public  void sound()
        {
            Console.WriteLine("Dog bark");
        }
    }
    class Cat : Animal
    {
        public new void sound()
        {
            base.sound();
            Console.WriteLine("Cat meow");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            //Cat c = new Cat();
            d.sound();
            //c.sound();
            Console.ReadLine();
        }
    }
}
