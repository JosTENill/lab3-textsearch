namespace TextSearch.Patterns;

public class SearchSubject
{
    private List<IObserver> _observers = new();

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void Notify(string message)
    {
        foreach (var observer in _observers)
            observer.Update(message);
    }
}

