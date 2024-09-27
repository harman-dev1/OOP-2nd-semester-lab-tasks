using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Complex
    {
        public int a;public  int b;
        public Complex()
        {

        }
        public Complex(int a,int c)
        {
            this.a = a;
            this.b = c;
        }
        public Complex(int k)
        {
            this.a = k;

        }

        public Complex( Complex c)
        {
            this.a = c.a;
            this.b = c.b;
        }
    }
}
