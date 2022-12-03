using GridTraveler.Tabulation;

namespace GridTraveler;

public class UnitTest1
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

    [Fact]
    public void Test5()
    {
        var solution = new Solution();
        var result = solution.Run(18, 18);

        Assert.Equal(2333606220, result);
    }
}