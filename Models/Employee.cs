namespace EmployeeInfoApprovalSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Default value
        public string Position { get; set; } = string.Empty; // Default value
        public Department Department { get; set; } = default!; // Non-nullable navigation property
    }
}
