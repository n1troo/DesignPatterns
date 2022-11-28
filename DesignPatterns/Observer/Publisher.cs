namespace DesignPatterns.Observer;

public class Publisher
{
    private readonly IList<ISubscribler> _subscriblers = new List<ISubscribler>();

    public void Subscrible(ISubscribler subscribler)
    {
        _subscriblers.Add(subscribler);
    }

    public void UnSubscrible(ISubscribler subscribler)
    {
        _subscriblers.Remove(subscribler);
    }

    public void Notify(string context)
    {
        foreach (var subscribler in _subscriblers)
        {
            subscribler.Update(context);
        }
    }
}