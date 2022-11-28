namespace DesignPatterns.Facade;

public class QualityScanner
{
    public IEnumerable<string> QualityScan(string githubUrl)
    {
        Console.WriteLine("Quality scan");
        return new[] { "erro1", "error2" };
    }
}