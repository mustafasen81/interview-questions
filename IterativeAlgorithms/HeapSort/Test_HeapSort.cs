using IterativeAlgorithms.HeapSort;

namespace HeapSort;

public class Test_HeapSort
{
    [Fact]
    public void Test_ShortInput()
    {
        int[] arr = new int[] { 3, 2 };
        Solution.Run(arr);

        Assert.Collection(arr, v => Assert.Equal(2, v), v => Assert.Equal(3, v));
    }

    [Fact]
    public void Test_BigInput()
    {
        int[] arr = new int[] { 5, 3, 6, 8, 1, 5, 8 };
        Solution.Run(arr);

        Assert.Collection(arr, v => Assert.Equal(1, v), v => Assert.Equal(3, v),
        v => Assert.Equal(5, v), v => Assert.Equal(5, v), v => Assert.Equal(6, v),
        v => Assert.Equal(8, v), v => Assert.Equal(8, v));
    }
}