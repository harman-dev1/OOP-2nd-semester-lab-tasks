
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_with_main
{
    class Program
    {
        class students
        {
            public string name;
            public int rollNo;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            students s1 = new students();
            Console.WriteLine("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No: ");
            s1.rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name : {0} Roll No : {1} CGPA : {2}", s1.name, s1.rollNo, s1.cgpa);
            Console.ReadKey();
        }
    }
}
