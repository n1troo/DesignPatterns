namespace DesignPatterns.Facade;

public class ScanFacade
{
    private QualityScanner _qualityScanner = new QualityScanner();
    private SecurityScanner _securityScanner = new SecurityScanner();
    private DependencyScanner _dependencyScanner = new DependencyScanner();
    private ReportGenerator _reportGenerator = new ReportGenerator();
    
    public void Scan(string gitHubUrl)
    {
        var quality = _qualityScanner.QualityScan(gitHubUrl);
        var security= _securityScanner.SequirityScan(gitHubUrl);
        var dependencyScan = _dependencyScanner.DependencyScan(gitHubUrl);
        _reportGenerator.GenerateReport(quality,security,dependencyScan);
    }
}