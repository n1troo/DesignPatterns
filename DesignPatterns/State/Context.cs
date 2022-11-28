namespace DesignPatterns.State;

public class Context
{
    private State _currrentState;
    public int AnvalibleCash { get; set; } = 1000;
 
    public void ChangeState(State newState)
    {
        _currrentState = newState;
    }

    public Context()
    {
        _currrentState = new NoCard(this);
    }

    
    public void InsertCard()
    {
        _currrentState.InsertCard();
    }

    public void EjectCard()
    {
        _currrentState.EjectCard();
    }

    public void InsertPin(int pin)
    {
        _currrentState.InsertPin(pin);
    }

    public void WithdrawCash(int amount)
    {
        _currrentState.WithdrawCash(amount);
    }
}