namespace TextSearch.Patterns;

public class SimpleSearchStrategy : ISearchStrategy
{
    public List<int> Search(string text, string word)
    {
        var result = new List<int>();
        int index = text.IndexOf(word);
        while (index != -1)
        {
            result.Add(index);
            index = text.IndexOf(word, index + 1);
        }
        return result;
    }
}

