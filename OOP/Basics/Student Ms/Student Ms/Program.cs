using Student_Ms.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Ms
{
    class Program
    {
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 for adding a student ");
            Console.WriteLine("Press 2 For view Students ");
            Console.WriteLine("Press 3 for top 3 students ");
            Console.WriteLine("Press 4 to exit ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static BL addStudents()
        {
            Console.Clear();
            BL s1 = new BL();
            Console.WriteLine("Enter Name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll No: ");
            s1.rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department: ");
            s1.department = Console.ReadLine();
            Console.WriteLine("Is hostelied Y || N: ");
            s1.isHostelied = char.Parse(Console.ReadLine());
            return s1;

        }

        static void Main(string[] args)
        {
            BL[] s = new BL[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudents();
                    count++;
                }
                else if (option == '2')
                {
                    viewStudents(s, count);
                }
            } while (option != 4);
        }

        static void viewStudents(BL[] s, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name : {0} Roll No : {1} CGPA : {2} Department : {3} IsHostelied : {4}", s[i].name, s[i].rollNo, s[i].cgpa, s[i].department, s[i].isHostelied);
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadKey();
            }
        }
    }
}
