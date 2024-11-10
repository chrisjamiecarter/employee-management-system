using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Blazor.Extensions;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attributes = fieldInfo!.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

        var output = (attributes != null && attributes.Length > 0) ? attributes.First().Name : null;

        return output ?? value.ToString();
    }
}
