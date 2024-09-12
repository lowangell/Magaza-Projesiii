using Mağaza_Zinciri;
using System;
using System.Collections.Generic;

namespace Magaza_Zinciri
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Yeni bir mağaza oluştur
            Store store = new Store("Tech Store", "Istanbul");

            // Yeni ürünler oluştur
            Product laptop = new Product(1, "Laptop", 1500.0m, 10);
            Product smartphone = new Product(2, "Smartphone", 800.0m, 20);

            // Ürünleri mağazaya ekle
            store.AddProduct(laptop);
            store.AddProduct(smartphone);

            // Yeni çalışanlar oluştur
            Employee emp1 = new Employee(1, "Sila Karahan", "Manager");
            Employee emp2 = new Employee(2, "Mihriban Isyar", "Salesperson");

            // Çalışanları mağazaya ekle
            store.AddEmployee(emp1);
            store.AddEmployee(emp2);

            // Yeni bir müşteri oluştur
            Customer customer1 = new Customer(1, "Selan Yildiz", "alice@example.com");

            // Satış işlemi oluştur
            SalesTransaction transaction1 = new SalesTransaction(1, laptop, customer1, 2);

            // Satış işlemini mağazaya ekle
            store.AddSalesTransaction(transaction1);

            // İşlemi göster
            transaction1.DisplayTransaction();

            // Konsolun kapanmasını engelle
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
