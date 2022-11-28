namespace DesignPatterns.Observer;

public class Subscribler : ISubscribler
{
    private string Name { get; set; }

    public Subscribler(string name)
    {
        Name = name;
    }
    public void Update(string context)
    {
        Console.WriteLine($"Subscribler {Name} notifed: {context}");
    }
}