using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHW.Models
{
    internal class Department
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }

        public int SalaryLimit { get; set; }

        private List<Employee> _employees = new List<Employee>();



        public Department(string name, int workerLimit, int salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
        }

        public List<Employee> Employees => _employees;

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

    }
}
