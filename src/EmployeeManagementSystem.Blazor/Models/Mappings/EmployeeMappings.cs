using EmployeeManagementSystem.Blazor.Models.Requests;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace EmployeeManagementSystem.Blazor.Models.Mappings;

public static class EmployeeMappings
{
    public static Employee ToDomain(this AddEmployeeRequest request)
    {
        return new Employee
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            ImageUrl = request.ImageUrl,
            Salary = request.Salary,
            EmployeeType = request.EmployeeType,
            JobTitle = request.JobTitle,
        };
    }
}
