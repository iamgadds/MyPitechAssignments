using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;

namespace ProductGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product("table", 350, 20);
            Product pr2 = new Product("chairs", 100, 35);

            List<Product> productList = new List<Product> { pr1, pr2 };
            ProductCollection pc = new ProductCollection(ref productList);

            char myDecision = 'n';
            string name;

            do
            {
                Console.WriteLine("1) Add \n2) Delete \n3) Display \n4) Search \n5) Query \n 6) Quit");
                int num1 = Convert.ToInt32(Console.ReadLine());

                switch (num1)
                {
                    case 1:
                        Console.WriteLine("Enter Product Name");
                         name = Console.ReadLine();
                        Console.WriteLine("Enter per unit Price");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Quantity");
                        int qty = Convert.ToInt32(Console.ReadLine());
                        pc.Add(new Product(name,price,qty));
                        break;

                    case 2:
                        Console.WriteLine("Enter Product Name You wish to remove");
                         name = Console.ReadLine();
                        pc.Delete(name);
                        break;

                    case 3:
                        pc.DisplayAll();
                        break;

                    case 4:
                        Console.WriteLine("Enter Product Name to search");
                        name = Console.ReadLine();
                        Product SearchedProduct = pc.Search(name);
                        Console.WriteLine(SearchedProduct);
                        break;

                    case 5:
                        Console.WriteLine("Enter price:");
                        double myPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Operand:(==, >, <)");
                        string operand = Console.ReadLine();

                        Product[] myProductArray = pc.QtyPrice(operand, myPrice);
                        foreach(Product i in myProductArray)
                        {
                            Console.WriteLine(i);
                        }

                        break;

                    default:
                        break;
                }

                Console.WriteLine("You wish to continue y/n");
                myDecision = Convert.ToChar(Console.ReadLine());

            } while (myDecision == 'y');
            
            Console.ReadLine();

        }
    }
}
