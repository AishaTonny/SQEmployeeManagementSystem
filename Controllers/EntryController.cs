using EmployeeInfoApprovalSystem.Data;
using EmployeeInfoApprovalSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfoApprovalSystem.Controllers
{
    public class EntryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch data if needed or return the view
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}
