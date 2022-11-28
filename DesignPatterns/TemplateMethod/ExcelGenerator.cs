namespace DesignPatterns.TemplateMethod;

public class ExcelGenerator : Generator
{
    protected override void PrepareData()
    {
        Console.WriteLine("prepare date excel");
    }

    protected override void GenerateFile()
    {
        Console.WriteLine("genereate excel file");
    }
}