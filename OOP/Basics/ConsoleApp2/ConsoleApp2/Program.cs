using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(5);
            Complex c3 = new Complex();
            Complex c4 = new Complex( c1);
            Console.WriteLine(c1.a+" "+c1.b);
            Console.WriteLine(c4.a+" "+c4.b);
            
            c1.a = 5;
            c2.b = 6;

            Console.WriteLine(c1.a+" "+c1.b);
            Console.WriteLine(c4.a + " " + c4.b);
            //Console.WriteLine(c1.a+" "+c1.b);

            Console.ReadLine();
        }
    }
}
