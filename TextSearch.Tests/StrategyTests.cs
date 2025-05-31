using TextSearch.Patterns;
using Xunit;

public class StrategyTests
{
    [Fact]
    public void SimpleSearchStrategy_FindsAllOccurrences()
    {
        var strategy = new SimpleSearchStrategy();
        var context = new SearchContext();
        context.SetStrategy(strategy);

        var result = context.ExecuteSearch("hello world, hello GPT", "hello");

        Assert.Equal(new List<int> { 0, 13 }, result);
    }
}

