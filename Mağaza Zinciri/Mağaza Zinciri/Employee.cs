using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mağaza_Zinciri;

namespace Mağaza_Zinciri
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }

        public Employee(int employeeId, string employeeName, string position)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Position = position;
        }
    }
}
