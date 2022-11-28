namespace DesignPatterns.Facade;

public class SecurityScanner
{
    public IEnumerable<string> SequirityScan(string githubUrl)
    {
        Console.WriteLine("Security scan");
        return new[] { "security 1" };
    }
}