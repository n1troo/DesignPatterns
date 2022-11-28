namespace DesignPatterns.Adapter;

public class SmsSender
{
    public void SendSMS(string to, string message)
    {
        Console.WriteLine($"Sendinng {message} to {to}");
    }
}