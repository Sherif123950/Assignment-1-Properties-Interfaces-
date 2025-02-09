using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Properties_Interfaces_.Property
{
    internal class Product
    {
        public Product(string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }
        private decimal price;
        private int stockQuantity;
        public string Name { get; set; }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("price must be positive.");
                }
                price = value;
            }
        }
        public int StockQuantity
        {
            get { return stockQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity can't be negative.");
                }
                stockQuantity = value;
            }
        }
        public bool IsStock => StockQuantity > 0;
        public void UpdateStock(int amount)
        {
            if (amount < 0 && Math.Abs(amount) > StockQuantity)
            {
                Console.WriteLine($"Insufficient Quantity!\nCurrent Product Quantity : {StockQuantity}");
                return;
            }
            StockQuantity += amount;
            Console.WriteLine($"Done!\nCurrent Product Quantity : {StockQuantity}");
        }
    }
}
