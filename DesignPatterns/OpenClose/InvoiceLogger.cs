namespace DesignPatterns.OpenClose;

public class InvoiceLogger 
{
    private readonly Invoice _invoice;

    public InvoiceLogger(Invoice invoice)
    {
        _invoice = invoice;
    }
    
    public void Display()
    {
        Console.WriteLine(_invoice.Number);
        Console.WriteLine(_invoice.Title);
        Console.WriteLine(_invoice.Total);
    }
}