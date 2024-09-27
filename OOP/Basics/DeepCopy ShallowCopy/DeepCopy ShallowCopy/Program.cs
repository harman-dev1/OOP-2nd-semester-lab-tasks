using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepCopy_ShallowCopy;

namespace DeepCopy_ShallowCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.name = "Harman";
            Class1 c2 = new Class1(c1);
            c2 = c1;
            Console.WriteLine("Name before changing is " + c1.name);
            Console.WriteLine("Name before changing is " + c2.name);

            c2.name = "Zain";

            Console.WriteLine("Name after changing is " + c1.name);
            Console.WriteLine("Name after changing is " + c2.name);
            Console.ReadLine();

        }
    }
}
