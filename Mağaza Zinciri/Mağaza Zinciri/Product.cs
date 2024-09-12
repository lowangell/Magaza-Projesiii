using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mağaza_Zinciri;

namespace Mağaza_Zinciri
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(int productId, string productName, decimal price, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public void UpdateQuantity(int amount)
        {
            Quantity += amount;
            Console.WriteLine($"Product {ProductName} quantity updated to {Quantity}.");
        }
    }
}
