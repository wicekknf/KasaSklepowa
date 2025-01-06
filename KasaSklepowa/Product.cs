using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaSklepowa
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public double Price { get; set; }

        public Product(string productName, string productNumber, double price)
        {
            ProductName = productName;
            ProductNumber = productNumber;
            Price = price;
        }
    }

}
