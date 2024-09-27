using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_lab
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
            s1.name = "Harman";
            s1.rollNo = 8;
            s1.cgpa = 2.8F;
            Console.WriteLine("Name :{0}  Roll No :{1}  CGPA :{2}  ", s1.name, s1.rollNo, s1.cgpa);
            students s2 = new students();
            s2.name = "Bateman";
            s2.rollNo = 6;
            s2.cgpa = 3.4F;
            Console.WriteLine("Name :{0} Roll No :{2} CGPA :{2}", s2.name, s2.rollNo, s2.cgpa);
            Console.Read();
        }
    }
}
