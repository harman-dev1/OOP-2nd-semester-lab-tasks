using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Saqure
{
    class Program
    {
        static void Main(string[] args)
        {
            float length;
            float area;
            string h;
            Console.WriteLine("Enter length: ");
            h = Console.ReadLine();
            length = float.Parse(h);
            area = length * 4;
            Console.Write("Area is ");
            Console.Write(area);
            Console.ReadKey();
        }
    }
}
