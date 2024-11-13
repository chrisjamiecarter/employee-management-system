using EmployeeManagementSystem.Blazor.Models;
using EmployeeManagementSystem.Blazor.Models.Requests;
using EmployeeManagementSystem.Blazor.Models.Responses;

namespace EmployeeManagementSystem.Blazor.Services;
public interface IEmployeeService
{
    Task<BaseResponse> AddEmployeeAsync(AddEmployeeRequest request);
    Task<BaseResponse> DeleteEmployeeAsync(Employee employee);
    Task<BaseResponse> EditEmployeeAsync(Employee employee);
    Task<GetEmployeeResponse> GetEmployeeAsync(Guid id);
    Task<GetEmployeesResponse> GetEmployeesAsync();
}