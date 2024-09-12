using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mağaza_Zinciri;

namespace Mağaza_Zinciri
{
    public class SalesTransaction
    {
        public int TransactionId { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        public SalesTransaction(int transactionId, Product product, Customer customer, int quantity)
        {
            TransactionId = transactionId;
            Product = product;
            Customer = customer;
            Quantity = quantity;
            TransactionDate = DateTime.Now;
            TotalAmount = product.Price * quantity;
        }

        public void DisplayTransaction()
        {
            Console.WriteLine($"Transaction ID: {TransactionId}, Product: {Product.ProductName}, Customer: {Customer.CustomerName}, Quantity: {Quantity}, Total Amount: {TotalAmount:C}, Date: {TransactionDate}");
        }
    }
}
