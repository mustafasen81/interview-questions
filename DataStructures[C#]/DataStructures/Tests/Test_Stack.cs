namespace Tests;

public class Test_Stack
{

    [Fact]
    public void Test_EmptyStack()
    {
        var stack = new DataStructures.Stack<int>();

        Assert.True(stack.Empty);
        Assert.Equal(0, stack.Size);
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Empty(stack);
    }

    [Fact]
    public void Test_Push()
    {
        var stack = new DataStructures.Stack<int>();
        stack.Push(2);
        stack.Push(5);
        stack.Push(6);

        Assert.False(stack.Empty);
        Assert.Equal(3, stack.Size);
        Assert.Collection(stack, val => Assert.Equal(6, val), val => Assert.Equal(5, val), val => Assert.Equal(2, val));
    }

    [Fact]
    public void Test_PeekAndPop()
    {
        var stack = new DataStructures.Stack<int>();
        stack.Push(2);
        stack.Push(5);
        stack.Push(6);

        Assert.False(stack.Empty);
        Assert.Equal(3, stack.Size);
        Assert.Equal(6, stack.Peek());
        Assert.Equal(6, stack.Pop());
        Assert.Equal(5, stack.Peek());
        Assert.Equal(5, stack.Pop());
        Assert.Equal(2, stack.Peek());
        Assert.Equal(2, stack.Pop());

        Assert.True(stack.Empty);
        Assert.Equal(0, stack.Size);
    }
}