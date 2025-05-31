namespace TextSearch.Patterns;

public interface ISearchStrategy
{
    List<int> Search(string text, string word);
}

