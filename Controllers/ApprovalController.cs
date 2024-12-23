using Microsoft.AspNetCore.Mvc;
using EmployeeInfoApprovalSystem.Data;
using System;

namespace EmployeeInfoApprovalSystem.Controllers
{
    public class ApprovalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApprovalController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }
    }
}
