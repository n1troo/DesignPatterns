﻿namespace DesignPatterns.State;

public class NoCard : State
{
    public NoCard(Context context) : base(context)
    {
    }

    public override void InsertCard()
    {
        Console.WriteLine("Card inserted");
        _context.ChangeState(new CardInserted(_context));
    }

    public override void EjectCard()
    {
        Console.WriteLine("No Card inserted yet");
    }

    public override void InsertPin(int pin)
    {
        Console.WriteLine("No Card inserted yet");
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("No Card inserted yet");
    }
}