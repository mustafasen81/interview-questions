using IterativeAlgorithms.BinarySearch;

namespace BinarySearch;

public class Test_BinarySearch
{
    [Fact]
    public void Test1()
    {
        int[] arr = new int[] { 1, 2, 4, 5, 7, 8 };

        Assert.Equal(2, Solution.Run(arr, 4));
        Assert.Equal(-1, Solution.Run(arr, 6));
    }
}