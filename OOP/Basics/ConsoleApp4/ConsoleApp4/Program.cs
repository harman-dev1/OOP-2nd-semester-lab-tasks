using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.BL;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            List<Data> access = new List<Data>();
            while(i <=3)
            {
                access.Add(signUp());
                i++;
            }
            access[0] = access[1];
            access[0].name = "Kakashii";
            foreach(var a in access)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
        static Data signUp()
        {
            Data d1 = new Data();
            Console.Write("Enter Name :");
            d1.name = Console.ReadLine();
            return d1;

        }
    }
}
