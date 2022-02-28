using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsHW.Models;

namespace GenericsHW.Interfaces
{
    internal interface IManage
    {
        List<Department> Department { get; }

        void AddDepartment(string name, int workerLimit, int salaryLimit);
        void AddEmployee(string name, string position, int salary, string departmentName);

        void RemoveDepartment(Department name);
        void RemoveEmployee(Employee name);

        List<Employee> GetEmployees(Department department);

        T Find<T>(T element);
    }
}
