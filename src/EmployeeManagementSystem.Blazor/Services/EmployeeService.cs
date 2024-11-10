using EmployeeManagementSystem.Blazor.Data;
using EmployeeManagementSystem.Blazor.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Blazor.Services;

public class EmployeeService(IDbContextFactory<ApplicationDbContext> factory) : IEmployeeService
{
    public async Task<GetEmployeesResponse> GetEmployees()
    {
        try
        {
            using var context = await factory.CreateDbContextAsync();

            var employees = await context.Employees.ToListAsync();

            return new GetEmployeesResponse
            {
                StatusCode = 200,
                Message = "Success",
                Employees = employees,
            };

        }
        catch (Exception exception)
        {
            return new GetEmployeesResponse
            { 
                StatusCode = 500,
                Message = $"Error getting employees: {exception.Message}",
                Employees = null,
            };
        }
    }
}
