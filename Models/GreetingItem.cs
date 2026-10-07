namespace MyFirstApi.Models;

public class GreetingItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public string Address { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}