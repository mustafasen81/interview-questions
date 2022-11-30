using BestSum.Memoization;

namespace HowSum;

public class Tests_Memoization
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run(7, new int[] { 5, 3, 4, 7 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(7, r));
    }
    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run(8, new int[] { 2, 3, 5 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(3, r), r => Assert.Equal(5, r));
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run(8, new int[] { 1, 4, 5 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(4, r), r => Assert.Equal(4, r));
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run(100, new int[] { 1, 2, 5, 25 });

        Assert.NotNull(result);
        Assert.Collection(result, r => Assert.Equal(25, r), r => Assert.Equal(25, r), r => Assert.Equal(25, r), r => Assert.Equal(25, r));
    }
}