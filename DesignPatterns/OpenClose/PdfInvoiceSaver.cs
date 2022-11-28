namespace DesignPatterns.OpenClose;

public class PdfInvoiceSaver : IInvoiceSaving
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine("Saving PDF");
    }
}