namespace DesignPatterns.OpenClose;

public class InvoicePersistence
{
    private readonly Invoice _invoice;
    private readonly IInvoiceSaving _invoiceSaving;

    public InvoicePersistence(Invoice invoice, IInvoiceSaving invoiceSaving)
    {
        _invoice = invoice;
        _invoiceSaving = invoiceSaving;
    }

    void Save()
    {
        _invoiceSaving.Save(_invoice);
    }
}