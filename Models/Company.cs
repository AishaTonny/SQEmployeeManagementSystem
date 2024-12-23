namespace EmployeeInfoApprovalSystem.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Default value to avoid null
        public string Location { get; set; } = string.Empty; // Default value to avoid null
    }
}
