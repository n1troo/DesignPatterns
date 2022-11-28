namespace DesignPatterns.TemplateMethod;

public class PdfGenerator : Generator
{
    protected override void GetData()
    {
        Console.WriteLine("get data ovverided for pdf");
    }

    protected override void PrepareData()
    {
        Console.WriteLine("Prepare data for pdf");
    }

    protected override void GenerateFile()
    {
        Console.WriteLine("generate file pdf");
    }
}