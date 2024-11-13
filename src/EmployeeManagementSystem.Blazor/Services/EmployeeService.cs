using EmployeeManagementSystem.Blazor.Data;
using EmployeeManagementSystem.Blazor.Models;
using EmployeeManagementSystem.Blazor.Models.Mappings;
using EmployeeManagementSystem.Blazor.Models.Requests;
using EmployeeManagementSystem.Blazor.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Blazor.Services;

public class EmployeeService(IDbContextFactory<ApplicationDbContext> factory) : IEmployeeService
{
    public async Task<BaseResponse> AddEmployeeAsync(AddEmployeeRequest request)
    {
        try
        {
            using var context = await factory.CreateDbContextAsync();

            await context.Employees.AddAsync(request.ToDomain());

            var created = await context.SaveChangesAsync();

            if (created > 0)
            {
                return new BaseResponse
                {
                    StatusCode = 200,
                    Message = "Employee added successfully",
                };
            }
            else
            {
                return new BaseResponse
                {
                    StatusCode = 400,
                    Message = $"Error adding employee",
                };
            }
        }
        catch (Exception exception)
        {
            return new BaseResponse
            {
                StatusCode = 500,
                Message = $"Error adding employee: {exception.Message}",
            };
        }
    }

    public async Task<BaseResponse> DeleteEmployeeAsync(Employee employee)
    {
        try
        {
            using var context = await factory.CreateDbContextAsync();

            context.Employees.Remove(employee);

            var deleted = await context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new BaseResponse
                {
                    StatusCode = 200,
                    Message = "Employee deleted successfully",
                };
            }
            else
            {
                return new BaseResponse
                {
                    StatusCode = 400,
                    Message = $"Error deleting employee",
                };
            }
        }
        catch (Exception exception)
        {
            return new BaseResponse
            {
                StatusCode = 500,
                Message = $"Error deleting employee: {exception.Message}",
            };
        }
    }

    public async Task<BaseResponse> EditEmployeeAsync(Employee employee)
    {
        try
        {
            using var context = await factory.CreateDbContextAsync();

            context.Employees.Update(employee);

            var updated = await context.SaveChangesAsync();

            if (updated > 0)
            {
                return new BaseResponse
                {
                    StatusCode = 200,
                    Message = "Employee updated successfully",
                };
            }
            else
            {
                return new BaseResponse
                {
                    StatusCode = 400,
                    Message = $"Error updating employee",
                };
            }
        }
        catch (Exception exception)
        {
            return new BaseResponse
            {
                StatusCode = 500,
                Message = $"Error updating employee: {exception.Message}",
            };
        }
    }

    public async Task<GetEmployeeResponse> GetEmployeeAsync(Guid id)
    {
        try
        {
            using var context = await factory.CreateDbContextAsync();

            var employee = await context.Employees.SingleOrDefaultAsync(e => e.Id == id);

            if (employee != null)
            {
                return new GetEmployeeResponse
                {
                    StatusCode = 200,
                    Message = "Success",
                    Employee = employee,
                };
            }
            else
            {
                return new GetEmployeeResponse
                {
                    StatusCode = 404,
                    Message = $"Unable to get employee with id: {id}",
                    Employee = employee,
                };
            }

        }
        catch (Exception exception)
        {
            return new GetEmployeeResponse
            {
                StatusCode = 500,
                Message = $"Error getting employee: {exception.Message}",
                Employee = null,
            };
        }
    }

    public async Task<GetEmployeesResponse> GetEmployeesAsync()
    {
        try
        {
            using var context = await factory.CreateDbContextAsync();

            var employees = await context.Employees
                .OrderBy(e => e.JobTitle)
                .ThenBy(e => e.EmployeeType)
                .ThenBy(e => e.Salary)
                .ThenBy(e => e.Name)
                .ToListAsync();

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
