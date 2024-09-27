using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overriding
{
    class baseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base Class ");
        }
    }
    class derived : baseClass
    {
        public override void show()
        {
            Console.WriteLine("Derived Class ");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            baseClass obj = new baseClass();
            obj.show();

            obj = new derived();
            obj.show();

            Console.ReadKey();
        }
    }
}
