namespace TextSearch.Patterns;

public class LoggerObserver : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"[Logger] {message}");
    }
}

