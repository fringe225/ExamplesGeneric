using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHW.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string  Position { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string position, string departmentName, int salary)
        {
            Name = name;
            Position= position;
            Department= departmentName;
            Salary= salary;
        }
    }
}
