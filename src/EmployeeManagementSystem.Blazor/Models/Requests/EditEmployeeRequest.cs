using System.ComponentModel.DataAnnotations;
using EmployeeManagementSystem.Blazor.Enums;

namespace EmployeeManagementSystem.Blazor.Models.Requests;

public class EditEmployeeRequest
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [Required]
    public decimal Salary { get; set; }

    [Required]
    public EmployeeType EmployeeType { get; set; }

    [Required]
    public JobTitle JobTitle { get; set; }
}
