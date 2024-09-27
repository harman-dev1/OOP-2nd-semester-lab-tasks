using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class dummy
        {
            int a, b;
            public void setData(int x,int y)
            {
                a = x; b = y;
            }
            public void showData()
            {
               Console.WriteLine( "a = {0} b = {1}",a,b);
            }
        }
        class dummy2
        {
            int a, b;
            public void setData2(int x, int y)
            {
                a = x; b = y;
            }
            public void showData2()
            {
                Console.WriteLine("a = {0} b = {1}", a, b);
            }
        }
        static void Main(string[] args)
        {
            dummy2 d1 = new dummy2() ;
            d1.setData2(3, 5);

            dummy2 d2 = d1;
            d2.showData2();
            Console.ReadKey();

        }
    }
}
