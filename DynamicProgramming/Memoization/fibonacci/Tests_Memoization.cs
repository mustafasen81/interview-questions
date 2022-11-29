using Fibonacci.Memoization;

namespace Fibonacci;

public class Tests_Memoization
{
    [Fact(Timeout = 2000)]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run(6);

        Assert.Equal(8, result);
    }

    [Fact(Timeout = 2000)]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run(7);

        Assert.Equal(13, result);
    }

    [Fact(Timeout = 2000)]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run(8);

        Assert.Equal(21, result);
    }

    [Fact(Timeout = 2000)]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run(50);

        Assert.Equal(12586269025, result);
    }
}