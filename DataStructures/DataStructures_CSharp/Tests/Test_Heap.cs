namespace Tests;

public class Test_Heap
{
    [Fact]
    public void Test_EmptyHeap()
    {
        var heap = new DataStructures.Heap<int>();

        Assert.True(heap.Empty);
        Assert.Equal(0, heap.Size);
    }

    [Fact]
    public void Test_InsertAndPoll()
    {
        var heap = new DataStructures.Heap<int>();

        heap.Insert(1);
        Assert.False(heap.Empty);
        Assert.Equal(1, heap.Size);

        heap.Insert(13);
        heap.Insert(4);
        heap.Insert(0);
        heap.Insert(10);

        Assert.False(heap.Empty);
        Assert.Equal(5, heap.Size);
        Assert.Equal(0, heap.Poll());
        Assert.Equal(1, heap.Poll());
        Assert.Equal(4, heap.Poll());
        Assert.Equal(10, heap.Poll());
        Assert.Equal(13, heap.Poll());

        Assert.True(heap.Empty);
        Assert.Equal(0, heap.Size);

        Assert.Throws<InvalidOperationException>(() => heap.Poll());
    }

    [Fact]
    public void Test_Remove()
    {
        var heap = new DataStructures.Heap<int>();

        heap.Insert(1);
        heap.Insert(13);
        heap.Insert(4);
        heap.Insert(0);
        heap.Insert(10);

        Assert.False(heap.Empty);
        Assert.Equal(5, heap.Size);

        heap.Remove(4);
        Assert.False(heap.Empty);
        Assert.Equal(4, heap.Size);

        Assert.Equal(0, heap.Poll());
        Assert.Equal(1, heap.Poll());

        heap.Remove(13);
        Assert.False(heap.Empty);
        Assert.Equal(1, heap.Size);

        Assert.Equal(10, heap.Poll());

        Assert.True(heap.Empty);
        Assert.Equal(0, heap.Size);

        Assert.Throws<InvalidOperationException>(() => heap.Remove(10));
    }
}