using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_lab_2
{
    internal class Program
    {
        static void add()
        {
            ProductService productService = new ProductService();
            int num = 0;
            while (num != 3)
            {
                Console.WriteLine("Choose A Product type to add: ");
                Console.WriteLine("1. Electronics");
                Console.WriteLine("2. Groceries");
                Console.WriteLine("3. Exit");
                num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Enter Product Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Name: ");
                    string nam = Console.ReadLine();
                    Console.WriteLine("Enter Product Price: ");
                    double pri = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product warranty period: ");
                    int wan = int.Parse(Console.ReadLine());
                    Electronics electronics = new Electronics();
                    electronics.Name = nam;
                    electronics.Id = id;
                    electronics.Price = pri;
                    electronics.WarrantyPeriod = wan;
                    productService.add(electronics);

                    Console.WriteLine("Product added successfully!");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Enter Product Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product Name: ");
                    string nam = Console.ReadLine();
                    Console.WriteLine("Enter Product Price: ");
                    double pri = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Product expiry date: ");
                    string dat = Console.ReadLine();
                    Groceries grocies = new Groceries();
                    grocies.Name = nam;
                    grocies.Id = id;
                    grocies.Price = pri;
                    grocies.Date = dat;
                    productService.add(grocies);
                }
            }

        }
        static string getProductsById()
        {
            Console.WriteLine("Enter the id : ");
            int num = int.Parse(Console.ReadLine());
            ProductService productService=new ProductService();
            return productService.get(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Management System!");
            int num = 0;
            while (num!=4)
            {
                Console.WriteLine("Press 1 to Add : ");
                Console.WriteLine("Press 2 to get by id  : ");
                Console.WriteLine("Press 3 to display all : ");
                Console.WriteLine("Press 4 to exit: ");
                num = int.Parse(Console.ReadLine());
                if(num==1)
                {
                    add();
                }
                else if (num==2)
                {
                   string prod= getProductsById();
                    if(prod!="")
                    {
                        Console.WriteLine("Id : "+prod);
                    }
                    else
                    {
                        Console.WriteLine("Not Present");
                    }
                }
                else if ( num==3) 
                {
                    ProductService productService=new ProductService();
                    string data =productService.getAllProducts();
                    string[] line = data.Split('\n');
                    for(int  i=0;i< line.Length-1;i++)
                    {
                        Console.WriteLine("Id : " + line[i]);
                    }
                }
            }

        }
    }
}
