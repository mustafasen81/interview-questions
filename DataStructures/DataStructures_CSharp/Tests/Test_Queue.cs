namespace Tests;

public class Test_Queue
{

    [Fact]
    public void Test_EmptyQueue()
    {
        var queue = new DataStructures.Queue<int>();

        Assert.True(queue.Empty);
        Assert.Equal(0, queue.Size);
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        Assert.Empty(queue);
    }

    [Fact]
    public void Test_Enqueue()
    {
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(2);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Assert.False(queue.Empty);
        Assert.Equal(3, queue.Size);
        Assert.Collection(queue, val => Assert.Equal(2, val), val => Assert.Equal(5, val), val => Assert.Equal(6, val));
    }

    [Fact]
    public void Test_PeekAndDequeue()
    {
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(2);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Assert.False(queue.Empty);
        Assert.Equal(3, queue.Size);
        Assert.Equal(2, queue.Peek());
        Assert.Equal(2, queue.Dequeue());
        Assert.Equal(5, queue.Peek());
        Assert.Equal(5, queue.Dequeue());
        Assert.Equal(6, queue.Peek());
        Assert.Equal(6, queue.Dequeue());

        Assert.True(queue.Empty);
        Assert.Equal(0, queue.Size);
    }
}