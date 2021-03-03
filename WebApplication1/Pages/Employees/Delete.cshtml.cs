using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Model;
using Employees.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public DeleteModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [BindProperty]
        public Employee Employee { get; set; }

        public IActionResult OnGet(int id)
        {
            Employee = employeeRepository.GetEmployee(id);
            if (Employee != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/NotFound");
            }
        }
        public IActionResult OnPost()
        {
            Employee deletedEmployee = employeeRepository.DeleteEmployee(Employee.Id);
            if (deletedEmployee != null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage("NotFound");
            }

        }

    }
}