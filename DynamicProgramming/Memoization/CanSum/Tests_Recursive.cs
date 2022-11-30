using CanSum.Recursive;

namespace CanSum;

public class Tests_Recursive
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 2, 3 });
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 5, 3, 4, 7 });
        Assert.True(result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 2, 4 });
        Assert.False(result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run(8, new int[] { 2, 3, 5 });
        Assert.True(result);
    }

    [Fact]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.Run(300, new int[] { 7, 14 });
        Assert.False(result);
    }
}