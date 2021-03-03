using Employees.Model;
using System;
using System.Collections.Generic;

namespace Employees.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee DeleteEmployee(int id);
    }
}
