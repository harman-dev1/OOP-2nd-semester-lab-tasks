using Sign_In_and_Sign_Out_Application.TestBl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_In_and_Sign_Out_Application
{
    class Program
    {
        public static string SignIn(users[] u, int count, string emailOfUsers, int passwordsOfUsers)
        {
            for (int i = 0; i < count; i++)
            {
                if (u[i].role == "Admin" || u[i].role == "admin" || u[i].role == "Teller" || u[i].role == "teller")
                {
                    if (u[i].email == emailOfUsers && u[i].password == passwordsOfUsers)
                    {
                        return u[i].role;
                    }
                }
            }
            return "";
        }
        static void Main(string[] args)
        {
            users[] u = new users[10];
            users[] roleOfUsers = new users[10];
            char option;
            string role;
            string emailOfUsers;
            int passwordOfUsers;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    Console.Clear();
                    Console.Write("Enter Email : ");
                    emailOfUsers = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    passwordOfUsers = int.Parse(Console.ReadLine()); 
                    role = SignIn(u,count,emailOfUsers,passwordOfUsers);
                    if(role == "Admin" || role == "admin")
                    {
                        Console.WriteLine("Enter as admin");
                        Console.ReadKey();
                    }
                    if(role == "Teller" || role == "teller")
                    {
                        Console.WriteLine("Enter as a teller");
                        Console.ReadKey();
                    }
                }
                if (option == '2')
                {
                    u[count] = signUp(u, count);

                    for (int i = 0; i < count; i++)
                    {
                        Console.Clear();
                        if (u[count].email == u[i].email)
                        {
                            Console.WriteLine("The user already exists:-)");
                            Console.WriteLine("Enter another user:-)");
                            u[count].email = Console.ReadLine();
                            if (u[count].email != u[i].email)
                            {
                                break;
                            }
                            else if (u[count].email == u[i].email)
                            {
                                Console.WriteLine("The user already exists:-)");
                                Console.WriteLine("Enter another user:-)");
                                u[count].email = Console.ReadLine();
                            }
                            if (u[count].email == u[i].email)
                            {
                                Console.Write("You can not access to system ");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                    }
                    Console.WriteLine("Sign Up Successfully");
                    Console.ReadKey();
                    count++;

                }
            }
            while (option != '3');
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1.Sign In...");
            Console.WriteLine("2.Sign Up...");
            Console.WriteLine("3.Exit:-(");
            Console.Write("Enter Option : ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static users signUp(users[] u, int count)
        {
            Console.Clear();
            users u1 = new users();
            Console.Write("Enter Email : ");
            u1.email = Console.ReadLine();
            Console.Write("Enter Password : ");
            u1.password = int.Parse(Console.ReadLine());
            Console.Write("Enter Role : ");
            u1.role = Console.ReadLine();
            if (u1.role == "Teller" || u1.role == "Admin" || u1.role == "teller" || u1.role == "admin")
            {
                
                return u1;
            }
            else
            {
                while (u1.role != "Teller" || u1.role != "Admin")
                {
                    if (u1.role == "Customer" || u1.role == "customer")
                    {
                        Console.WriteLine("You can not SignUp as a Customer directly");
                        Console.Write("Enter Role Again : ");
                        u1.role = Console.ReadLine();
                        Console.WriteLine("You Can not SignUp directly :-(");
                        Console.Write("Enter Role Again : ");
                        u1.role = Console.ReadLine();
                    }
                    Console.WriteLine("You Can not SignUp directly :-(");
                    Console.WriteLine("Enter Role Again...");
                    u1.role = Console.ReadLine();
                    if (u1.role == "Teller" || u1.role == "Admin" || u1.role == "teller" || u1.role == "admin")
                    {
                        break;
                    }
                }
            }
            
            return u1;
        }
    }
}
