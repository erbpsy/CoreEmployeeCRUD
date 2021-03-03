using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public string PhotoPath { get; set; }
        public string Email { get; set; }
        public Dept? Department { get; set; }

    }

}
