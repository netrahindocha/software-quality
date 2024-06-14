using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Product
    {
        // Defining Properties
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        // Parameterized Constructor with properties
        public Product(int productId, string productName, double price, int stock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // Method to Increase the Stock
        public void IncreaseStock(int numOfProducts)
        {
            if (numOfProducts > 0)
            {
                Stock += numOfProducts;
            }
            else 
            {
                Stock += 0;
            }
        }

        // Method to Decrease the Stock
        public void DecreaseStock(int numOfProducts) 
        {
            if (numOfProducts > 0 && numOfProducts <= Stock)
            {
                Stock -= numOfProducts;
            }
            else 
            {
                Stock -= 0;
            }
        }

    }
}
