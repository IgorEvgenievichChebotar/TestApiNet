using TestApiNet.Models;

namespace TestApiNet.Services;

public class PeopleService
{
    public List<Person> People { get; set; } = new()
    {
        new Person
        {
            Name = "Алексей", Age = 27, Email = "alexey@mail.com", Children = new List<Child>
            {
                new() { Name = "Стёпа", Age = 10 },
                new() { Name = "Тёма", Age = 6 }
            }
        },
        new Person
        {
            Name = "Иван", Age = 45, Email = "ivan@mail.com", Children = new List<Child>
            {
                new() { Name = "Ира", Age = 18 },
            }
        }
    };
}