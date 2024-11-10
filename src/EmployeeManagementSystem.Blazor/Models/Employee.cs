using EmployeeManagementSystem.Blazor.Enums;

namespace EmployeeManagementSystem.Blazor.Models;

public class Employee
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public string ImageUrl { get; set; }

    public decimal Salary { get; set; }

    public EmployeeType EmployeeType { get; set; }

    public JobTitle JobTitle { get; set; }
}
