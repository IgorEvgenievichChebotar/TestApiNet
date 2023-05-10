namespace TestApiNet.Models;

public class Person
{
    public string Name { get; set; }
    public ushort Age { get; set; }
    public string Email { get; set; }
    public List<Child> Children { get; set; }
}