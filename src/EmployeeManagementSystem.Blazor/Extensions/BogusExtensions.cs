namespace EmployeeManagementSystem.Blazor.Extensions;

public static class BogusExtensions
{
    public static string Avatar(this Bogus.DataSets.Images faker)
    {
        return $"https://avatars.githubusercontent.com/u/{faker.Random.Int(0, 100000000)}";
    }
}
