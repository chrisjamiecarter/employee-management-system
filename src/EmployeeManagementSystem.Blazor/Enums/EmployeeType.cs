using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Blazor.Enums;

public enum EmployeeType
{
    [Display(Name = "Full Time")]
    FullTime,
    [Display(Name = "Part Time")]
    PartTime,
    [Display(Name = "Contractor")]
    Contractor,
}
