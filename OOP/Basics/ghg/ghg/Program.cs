using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the date in the format DDMMYY: ");
            string input = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParseExact(input, "ddMMyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                int day = date.Day;
                int month = date.Month;
                int year = date.Year;

                Console.WriteLine($"Day: {day}");
                Console.WriteLine($"Month: {month}");
                Console.WriteLine($"Year: {year}");
            }
            else
            {
                Console.WriteLine("Invalid input format. Please enter the date in the format DDMMYY.");
            }
            Console.ReadLine();
        }
    }
}
