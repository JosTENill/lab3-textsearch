namespace TextSearch.Patterns;

public class SearchContext
{
    private ISearchStrategy _strategy;

    public void SetStrategy(ISearchStrategy strategy)
    {
        _strategy = strategy;
    }

    public List<int> ExecuteSearch(string text, string word)
    {
        return _strategy.Search(text, word);
    }
}

