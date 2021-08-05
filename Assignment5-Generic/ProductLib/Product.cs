using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product
    {
        private string productName;
        private double unitPrice;
        private int qty;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int Quantity
        {
            get { return qty; }
            set { qty = value; }
        }

        public double Total
        {
            get { return qty * unitPrice; }
        }

        public Product(string name, double price, int qty)
        {
            this.ProductName = name;
            this.UnitPrice = price;
            this.Quantity = qty;
        }
        public override string ToString()
        {
            return string.Concat($"Product Name: {ProductName} Quantity: {Quantity} Total: {Total} ");
        }

    }
}
