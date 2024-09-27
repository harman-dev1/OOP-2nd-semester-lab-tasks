using Products_Management_System.Test.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] p = new Products[10];
            int count = 0;
            char option;
            do
            {
                option = menu();
                if (option == '1')
                {
                    p[count] = addProducts();
                    for(int i = 0; i < count; i++)
                    {
                        if(p[count].productId == p[i].productId)
                        {
                            Console.WriteLine("Please Enter Product Id agian this is already exist :-( ");
                            p[count].productId = Console.ReadLine();
                            if (p[count].productId != p[i].productId)
                            {
                                break;
                            }
                            else if(p[count].productId == p[i].productId)
                            {
                                Console.WriteLine("Please Enter Product Id agian this is already exist this is a your last chance otherwise system will terminate:-( ");
                                p[count].productId = Console.ReadLine();
                                if (p[count].productId == p[i].productId)
                                {
                                    Environment.Exit(0);
                                }
                            }
                                
                        }
                    }
                    count++;
                }
                if (option == '2')
                {
                    show(p, count);
                }
                if(option == '3')
                {
                    totalPrice(p,count);
                }
            } while (option != 4);
            Console.WriteLine("Presss any key to Continue :-(");
            Console.ReadLine();
        }
        static char menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("1.Add Products: ");
            Console.WriteLine("2.Show Products: ");
            Console.WriteLine("3.Total Store Worth: ");
            Console.WriteLine("4.Exit... ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static Products addProducts()
        {
            Console.Clear();
            Products p1 = new Products();
            Console.WriteLine("Enter Product Name: ");
            p1.productName = Console.ReadLine();
            Console.WriteLine("Enter productId: ");
            p1.productId = (Console.ReadLine());
            Console.WriteLine("Enter Brand Name: ");
            p1.brandName = Console.ReadLine();
            Console.WriteLine("Enter Categary: ");
            p1.category = Console.ReadLine();
            Console.WriteLine("Enter Country Name: ");
            p1.country = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            p1.price = float.Parse(Console.ReadLine());
            return p1;
        }
        static void show(Products[] p,int count)
        {
            Console.Clear();
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Product Name: {0} Product ID: {1} Brand Name: {2} Category: {3} Country Name: {4} Product Price: {5} ", p[i].productName, p[i].productId, p[i].brandName, p[i].category, p[i].country, p[i].price);
            }
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
        }
        static void totalPrice(Products[] p,int count)
        {
            Console.Clear();
            float totalPriceOfProducts = 0, a = 0;
            if(count == 0)
            {
                Console.WriteLine("No Product found yet :-(");
                Console.WriteLine("Press any to Continue...");
                Console.ReadLine();
            }
            else if(count == 1)
            {
                totalPriceOfProducts = adding(p,count);
                //totalPriceOfProducts = totalPriceOfProducts + p[count].price;
                Console.WriteLine("Total Price Of Products is :-) :{0} ", totalPriceOfProducts);
                Console.WriteLine("Press any to Continue...");
                Console.ReadLine();
            }
            else
            {

                for(int i = 0;i < count;i++)
                {
                    a = p[i].price;
                    totalPriceOfProducts = totalPriceOfProducts + a;
                }
                Console.WriteLine("Total Price Of Products is :-) :{0} ", totalPriceOfProducts);
                Console.WriteLine("Press any to Continue...");
                Console.ReadLine();

            }
        }
        static float adding(Products[] p,int count)
        {
            float totalPriceOfProducts = 0 , a = 0, b = 0;
            for(int i = 0;i < count;i++)
            {
                a = p[i].price;
                totalPriceOfProducts = a + totalPriceOfProducts;
            }
            b = totalPriceOfProducts;
            return b;
        }
    }
}
