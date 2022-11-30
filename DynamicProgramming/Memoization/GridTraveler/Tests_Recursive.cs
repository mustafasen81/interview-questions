using GridTraveler.Recursive;

namespace GridTraveler;

public class Tests_Recursive
{
    [Fact]
    public void Test1()
    {
        var solution = new Solution();
        var result = solution.Run(1, 1);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new Solution();
        var result = solution.Run(2, 3);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new Solution();
        var result = solution.Run(3, 2);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Test4()
    {
        var solution = new Solution();
        var result = solution.Run(3, 3);

        Assert.Equal(6, result);
    }
}