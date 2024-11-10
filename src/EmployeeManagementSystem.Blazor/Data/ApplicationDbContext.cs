using Bogus;
using EmployeeManagementSystem.Blazor.Enums;
using EmployeeManagementSystem.Blazor.Extensions;
using EmployeeManagementSystem.Blazor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Blazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Employee>().HasData(SeedFakeEmployees());
    }

    private static List<Employee> SeedFakeEmployees()
    {
        Randomizer.Seed = new Random(19890309);

        var faker = new Faker<Employee>()
            .RuleFor(p => p.Id, f => f.Random.Guid())
            .RuleFor(p => p.Name, f => f.Name.FullName())
            .RuleFor(p => p.ImageUrl, f => f.Image.Avatar())
            .RuleFor(p => p.Salary, f => f.Random.Decimal(20000, 200000))
            .RuleFor(p => p.EmployeeType, f => f.PickRandom<EmployeeType>())
            .RuleFor(p => p.JobTitle, f => f.PickRandom<JobTitle>());

        return faker.Generate(50);
    }
}
