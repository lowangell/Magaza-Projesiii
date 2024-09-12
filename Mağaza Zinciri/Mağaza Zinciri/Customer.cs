using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mağaza_Zinciri;

namespace Mağaza_Zinciri
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }

        public Customer(int customerId, string customerName, string email)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Email = email;
        }
    }
}
