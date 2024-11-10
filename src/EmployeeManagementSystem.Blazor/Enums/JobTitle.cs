using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Blazor.Enums;

public enum JobTitle
{
    [Display(Name = "CEO")]
    CEO,
    [Display(Name = "CFO")]
    CFO,
    [Display(Name = "Accountant")]
    Accountant,
    [Display(Name = "HR Manager")]
    HrManager,
    [Display(Name = "Marketing Manager")]
    MarketingManager,
    [Display(Name = "Sales Manager")]
    SalesManager,
    [Display(Name = "Software Engineer")]
    SoftwareEngineer,
    [Display(Name = "Data Analyst")]
    DataAnalyst,
    [Display(Name = "Customer Support")]
    CustomerSupport,
}
