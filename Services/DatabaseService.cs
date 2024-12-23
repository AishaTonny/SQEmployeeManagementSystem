using System;
using EmployeeInfoApprovalSystem.Data;
using EmployeeInfoApprovalSystem.Models;

namespace EmployeeInfoApprovalSystem.Services
{
    public class DatabaseService
    {
        private readonly ApplicationDbContext _context;

        public DatabaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedDatabase()
        {
            if (!_context.Companies.Any())
            {
                _context.Companies.Add(new Company { Name = "Example Corp", Location = "New York" });
                _context.SaveChanges();
            }
        }
    }
}
