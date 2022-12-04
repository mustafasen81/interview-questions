using CanConstruct.Tabulation;
namespace CanConstruct;

public class Tests_Tabulation
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" });
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
        Assert.False(result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" });
        Assert.True(result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" });
        Assert.False(result);
    }
}