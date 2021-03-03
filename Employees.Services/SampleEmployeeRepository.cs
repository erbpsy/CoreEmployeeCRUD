using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Employees.Services
{
    public class SampleEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _Employees;

        public SampleEmployeeRepository()
        {
            _Employees = new List<Employee>() {
                new Employee()
                {
                    Id = 1,
                    Name = "Bhanu Pratap",
                    Sex = Gender.Male,
                    Email = "bhanupratap@bhanupratap.com",
                    Department = Dept.IT,
                    PhotoPath = "male.png"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Ran Vijai Singh",
                    Sex = Gender.Male,
                    Email = "ranvijai@bhanupratap.com",
                    Department = Dept.IT,
                    PhotoPath = "male.png"
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Neha Tyagi",
                    Sex = Gender.Female,
                    Email = "nehatyagi@bhanupratap.com",
                    Department = Dept.HR,
                    PhotoPath = "female.png"
                },
                 new Employee()
                 {
                     Id = 4,
                     Name = "Priyanka",
                     Sex = Gender.Female,
                     Email = "priyanka@bhanupratap.com",
                     Department = Dept.IT
                 },
                 new Employee()
                 {
                     Id = 5,
                     Name = "Abc ",
                     Sex = Gender.LGBT,
                     Email = "abc@bhanupratap.com",
                     Department = Dept.Payroll,
                     PhotoPath = "lgbt.png"
                 }};

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _Employees;
        }
        public Employee GetEmployee(int id)
        {
            return _Employees.FirstOrDefault(emp => emp.Id == id);
        }
        public Employee DeleteEmployee(int id)
        {
            Employee employee = _Employees.FirstOrDefault(emp => emp.Id == id);
            _Employees.Remove(employee);
            return employee;
        }
    }
}
