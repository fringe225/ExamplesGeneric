using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsHW.Interfaces;
using GenericsHW.Models;

namespace GenericsHW.Services
{
    internal class Manage : IManage
    {
        private List<Department> _departments = new List<Department>();
        public List<Department> Departments => _departments;

       
        public void AddDepartment(string name, int workerLimit, int salaryLimit)
        {
            Department department = new Department(name, workerLimit, salaryLimit);
            _departments.Add(department);
        }

        public void AddEmployee(string name, string position, int salary, string departmentName)
        {
            Employee employee = new Employee(name,position,departmentName,salary);
            foreach (var department in _departments)
            {
                if (department.Name.ToLower() == departmentName.ToLower())
                {
                    department.AddEmployee(employee);
                }
            }
        }


        public void RemoveDepartment(Department department)
        {

            _departments.Remove(department);
        }

        public void RemoveEmployee(Employee employee)
        {
            foreach (var department in _departments)
            {
                foreach (var employeeTemp in department.Employees)
                {
                    if (employee == employeeTemp)
                    {
                        department.Employees.Remove(employee);
                    }
                }
            }

        }


        public List<Employee> GetEmployees(Department department)
        {
            foreach (var department1 in _departments)
            {
                return department1.Employees;
            }

            return null;
        }


     
    }
}
