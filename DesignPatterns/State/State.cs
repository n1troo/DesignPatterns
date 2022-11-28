﻿namespace DesignPatterns.State;

public abstract class State
{
    protected Context _context;

    public int AvailableCash { get; set; } = 10000;
    
    protected State(Context context)
    {
        _context = context;
    }

    public abstract void InsertCard();
    public abstract void EjectCard();
    public abstract void InsertPin(int pin);
    public abstract void WithdrawCash(int amount);
    

}