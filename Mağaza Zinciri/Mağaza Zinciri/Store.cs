using Mağaza_Zinciri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mağaza_Zinciri
{
    public class Store
    {
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public List<Product> Products { get; set; }
        public List<Employee> Employees { get; set; }
        public List<SalesTransaction> SalesTransactions { get; set; }

        public Store(string name, string location)
        {
            StoreName = name;
            StoreLocation = location;
            Products = new List<Product>();
            Employees = new List<Employee>();
            SalesTransactions = new List<SalesTransaction>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"Product {product.ProductName} added to store {StoreName}.");
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine($"Employee {employee.EmployeeName} added to store {StoreName}.");
        }

        public void AddSalesTransaction(SalesTransaction transaction)
        {
            SalesTransactions.Add(transaction);
            Console.WriteLine("Sales transaction added.");
        }
    }
}
