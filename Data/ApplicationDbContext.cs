using Microsoft.EntityFrameworkCore;
using EmployeeInfoApprovalSystem.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmployeeInfoApprovalSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
