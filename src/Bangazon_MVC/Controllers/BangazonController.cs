using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Bangazon_MVC.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Bangazon_MVC.Controllers
{
    public class BangazonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            var query = from c in _context.Customer

                        select c;

            var employeeDepartment = (from emp in _myEmployeeContext.Employee
                                      join dept in _myEmployeeContext.Department
                                      on emp.DepartmentId equals dept.DepartmentId
                                      orderby dept.DepartmentName
                                      select new EmployeeDetailViewModel
                                      {
                                          Name = emp.Name,
                                          EmployeeId = emp.EmployeeId,
                                          DepartmentName = dept.DepartmentName
                                      }).ToList();

            EmployeeDepartmentDetailViewModel employeeDetails = new EmployeeDepartmentDetailViewModel
            {
                Employees = employeeDepartment
            };

            return View(employeeDetails);
        }
    }
}
