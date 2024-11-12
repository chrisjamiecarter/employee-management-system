using EmployeeManagementSystem.Blazor.Models.Requests;
using EmployeeManagementSystem.Blazor.Models.Responses;

namespace EmployeeManagementSystem.Blazor.Services;
public interface IEmployeeService
{
    Task<BaseResponse> AddEmployeeAsync(AddEmployeeRequest request);
    Task<GetEmployeesResponse> GetEmployeesAsync();
}