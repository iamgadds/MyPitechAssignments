using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class ProductCollection
    {
        //private List<string> myProducts;
        public List<Product> MyProducts;
        //{
        //    private set { myProducts = value; }
        //    get { return myProducts; }
        //}

        public ProductCollection(ref List<Product> product)
        {
            MyProducts = product;
        }

        public void Add(Product product)
        {
            MyProducts.Add(product);
        }

        public void Delete(string productName)
        {
            Product prod = MyProducts.Find(x => x.ProductName.Contains(productName));
            MyProducts.Remove(prod);
        }

        public void DisplayAll()
        {
            foreach(Product prod in MyProducts)
            {
                Console.WriteLine("ProductName: " + prod.ProductName + " ----Quantity: " + prod.Quantity + " ----Total: " + prod.Total);
            }
        }

        public Product Search(string product)
        {
            Product prod = MyProducts.Find(x => x.ProductName.Contains(product));
            return prod;
            
        }

        public Product[] QtyPrice(string opt, double price)
        {
            int count = MyProducts.Count;
            Product[] myArray = new Product[count];
            int p = 0;

            if (opt == "==")
            {
                p = 1;
            }
            else if (opt == ">")
            {
                p = 2;
            }
            else
            {
                p = 3;
            }
            List<Product> newprod;
            switch (p)
            {
                case 1:
                     newprod = MyProducts.FindAll(x => x.UnitPrice == price);

                    for (int i = 0; i < newprod.Count; i++)
                    {
                        myArray[i] = newprod[i];
                    }
                    break;

                case 2:
                    newprod = MyProducts.FindAll(x => x.UnitPrice < price);

                    for (int i = 0; i < newprod.Count; i++)
                    {
                        myArray[i] = newprod[i];
                    }
                    break;

                case 3:
                    newprod = MyProducts.FindAll(x => x.UnitPrice > price);

                    for (int i = 0; i < newprod.Count; i++)
                    {
                        myArray[i] = newprod[i];
                    }
                    break;

                default:
                    break;
            }

            return myArray;
            
        }
    }
}
