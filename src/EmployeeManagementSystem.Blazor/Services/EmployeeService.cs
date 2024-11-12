using System;
using EmployeeManagementSystem.Blazor.Data;
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
                    Message = "Success",
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

    public async Task<GetEmployeesResponse> GetEmployeesAsync()
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
