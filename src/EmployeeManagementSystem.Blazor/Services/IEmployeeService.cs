using EmployeeManagementSystem.Blazor.Models.Responses;

namespace EmployeeManagementSystem.Blazor.Services;
public interface IEmployeeService
{
    Task<GetEmployeesResponse> GetEmployees();
}