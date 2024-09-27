using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.BL
{
    class Class1
    {
        private int a, b;
        public void setData(int pa,int pb)
        {
            a = pa;
            b = pb;
        }
        public void showData()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.ReadLine();
        }
        public Class1 add(Class1 c2)
        {
            Class1 temp = new Class1();
            temp.a = a + c2.a;
            temp.b = b + c2.b;
            return temp; 
        }

    }
}
