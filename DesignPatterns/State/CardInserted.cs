namespace DesignPatterns.State;

public class CardInserted : State
{
    public CardInserted(Context context) : base(context)
    {
    }

    public override void InsertCard()
    {
        Console.WriteLine("Card already inserted");
    }

    public override void EjectCard()
    {
        Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
    }

    public override void InsertPin(int pin)
    {
        if (pin == 1234)
        {
            Console.WriteLine("Pin is correct");
            //_context state to pinInserted
            _context.ChangeState(new PinInserted(_context));
        }
        else
        {
            Console.WriteLine("Pin not correct");
            Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
        }
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("Inset pin first");
    }
}