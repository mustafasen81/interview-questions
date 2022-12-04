using AllConstruct.Tabulation;

namespace AllConstruct;

public class Tests_Tabulation
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var allConstructs = solution.Run("purple", new string[] { "purp", "p", "ur", "le", "purpl" });

        Assert.Collection<string[]>(allConstructs,
            construct => Assert.Collection<string>(construct, c => Assert.Equal("purp", c), c => Assert.Equal("le", c)),
            construct => Assert.Collection<string>(construct, c => Assert.Equal("p", c), c => Assert.Equal("ur", c), c => Assert.Equal("p", c), c => Assert.Equal("le", c)));
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var allConstructs = solution.Run("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" });

        Assert.Collection<string[]>(allConstructs,
            construct => Assert.Collection<string>(construct, c => Assert.Equal("abc", c), c => Assert.Equal("def", c)),
            construct => Assert.Collection<string>(construct, c => Assert.Equal("ab", c), c => Assert.Equal("c", c), c => Assert.Equal("def", c)),
            construct => Assert.Collection<string>(construct, c => Assert.Equal("abcd", c), c => Assert.Equal("ef", c)),
            construct => Assert.Collection<string>(construct, c => Assert.Equal("ab", c), c => Assert.Equal("cd", c), c => Assert.Equal("ef", c)));
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var allConstructs = solution.Run("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });

        Assert.False(allConstructs.Any());
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var allConstructs = solution.Run("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaz", new string[] { "a", "aa", "aaa", "aaaa", "aaaaa" });

        Assert.False(allConstructs.Any());
    }
}