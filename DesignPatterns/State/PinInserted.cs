namespace DesignPatterns.State;

public class PinInserted : State
{
    public PinInserted(Context context) : base(context)
    {
    }

    public override void InsertCard()
    {
        Console.WriteLine("Card alredy inserted card ");
    }

    public override void EjectCard()
    {
        Console.WriteLine("Card ejected.");
        _context.ChangeState(new NoCard(_context));
    }

    public override void InsertPin(int pin)
    {
        Console.WriteLine("Pin alredy inserted correct PIN");
    }

    public override void WithdrawCash(int amount)
    {
        if (amount < _context.AnvalibleCash)
        {
            Console.WriteLine($"Take you money now - {amount}");
            _context.AnvalibleCash -= amount;
            EjectCard();

            if (_context.AnvalibleCash == 0)
            {
                _context.ChangeState(new NoCash(_context));
            }
        }
        else
        {
            Console.WriteLine("Insufficient founds on mashinge");
            EjectCard();
        }
    }
}