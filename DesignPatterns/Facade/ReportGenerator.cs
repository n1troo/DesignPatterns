namespace DesignPatterns.Facade;

public class ReportGenerator
{
    public void GenerateReport(IEnumerable<string> qualityScanErrors, IEnumerable<string> securityScanErrors,
        IEnumerable<string> dependencyScanErrors)
    {
        Console.WriteLine("Quality Errors");
        Console.WriteLine(string.Join(",",qualityScanErrors));
        Console.WriteLine("Security Errors");
        Console.WriteLine(string.Join(",",securityScanErrors));
        Console.WriteLine("Deependecy Errors");
        Console.WriteLine(string.Join(",",dependencyScanErrors));
    }
}