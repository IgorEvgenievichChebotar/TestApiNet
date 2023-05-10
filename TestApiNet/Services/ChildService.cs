using TestApiNet.Models;

namespace TestApiNet.Services;

public class ChildService
{
    public List<Child> Children = new()
    {
        new() { Name = "Стёпа", Age = 10 },
        new() { Name = "Тёма", Age = 6 },
        new() { Name = "Ира", Age = 18 }
    };
}