using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for(int i = 0; i < 3;i++)
            {
                Console.Write("Enter no :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest = 0;
            for(int i = 0; i < 3;i++)
            {
                if(arr[i] > largest)
                {
                    largest = arr[i];
                }    
            }

            Console.WriteLine("Largest :" + largest);
            Console.ReadLine();
        }
    }
}
