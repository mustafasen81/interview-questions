using CountConstruct.Memoization;

namespace CountConstruct;

public class Tests_Memoization
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run("purple", new string[] { "purp", "p", "ur", "le", "purpl" });

        Assert.Equal(2, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" });

        Assert.Equal(1, result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" });
        Assert.Equal(4, result);
    }

    [Fact]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.Run("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        Assert.Equal(0, result);
    }
}