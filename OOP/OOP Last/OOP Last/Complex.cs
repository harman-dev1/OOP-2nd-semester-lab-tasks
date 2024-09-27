using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Last
{
    class Complex
    {
        
        public int a, b;

        public Complex(int x)
        {
            a = x;
        }
        public Complex()
        {

        }
        public Complex(Complex c)
        {
            a = c.a;
            c.a = 14;
        }
        public Complex(int x, int y)
        {
            a = x;
            b = y;
        }
    }
}
