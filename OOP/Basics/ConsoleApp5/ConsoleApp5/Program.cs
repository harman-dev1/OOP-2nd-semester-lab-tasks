using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.BL;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.setData(12, 13);
            Class1 c2 = new Class1();
            c2.setData(14,15);
            Class1 c3 = new Class1();
            c3 = c1.add(c2);
            c3.setData(c3);
            Console.ReadLine();
        }
    }
}
