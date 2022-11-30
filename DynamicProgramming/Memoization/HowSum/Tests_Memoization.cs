using HowSum.Memoization;

namespace HowSum;

public class Tests_Memoization
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 2, 3 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(2, r), r => Assert.Equal(2, r), r => Assert.Equal(3, r));
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 5, 3, 4, 7 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(3, r), r => Assert.Equal(4, r));
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 2, 4 });

        Assert.Null(result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run(8, new int[] { 2, 3, 5 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(2, r), r => Assert.Equal(2, r), r => Assert.Equal(2, r), r => Assert.Equal(2, r));
    }

    [Fact]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.Run(300, new int[] { 7, 14 });

        Assert.Null(result);
    }
}