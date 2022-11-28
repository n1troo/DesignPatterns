namespace DesignPatterns.OpenClose;

public class WordInvoiceSaver : IInvoiceSaving
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine("Saving WORD file");
    }
}