namespace EmployeeInfoApprovalSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Default value
        public Company Company { get; set; } = default!; // Use default! for non-nullable navigation properties
    }
}
