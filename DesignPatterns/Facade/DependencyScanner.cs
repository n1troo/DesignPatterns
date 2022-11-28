namespace DesignPatterns.Facade;

public class DependencyScanner
{
    public IEnumerable<string> DependencyScan(string githubUrl)
    {
        Console.WriteLine("dependency scan");
        return new[] { "deep1 erro", "deep2 error" };
    }
}