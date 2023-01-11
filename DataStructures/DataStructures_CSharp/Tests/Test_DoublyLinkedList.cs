namespace Tests;

public class Test_DoublyDoublyLinkedList
{
    [Fact]
    public void Test_EmptyList()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        Assert.True(list.Empty);
        Assert.Equal(0, list.Size);
        Assert.Throws<InvalidOperationException>(() => list.PeekFront());
        Assert.Throws<InvalidOperationException>(() => list.PeekBack());
    }

    [Fact]
    public void Test_Add()
    {
        var list = new DataStructures.DoublyLinkedList<int>();

        list.AddBack(5);
        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(5, list.PeekBack());


        list.AddBack(8);
        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        Assert.Collection(list, val => Assert.Equal(5, val), val => Assert.Equal(8, val));
    }

    [Fact]
    public void Test_AddFront()
    {
        var list = new DataStructures.DoublyLinkedList<int>();

        list.AddFront(5);
        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(5, list.PeekBack());


        list.AddFront(8);
        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(8, list.PeekFront());
        Assert.Equal(5, list.PeekBack());
    }

    [Fact]
    public void Test_AddBack()
    {
        var list = new DataStructures.DoublyLinkedList<int>();

        list.AddBack(5);
        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(5, list.PeekBack());


        list.AddBack(8);
        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(8, list.PeekBack());
    }

    [Fact]
    public void Test_IndexOf()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(8);
        list.Add(10);

        Assert.Equal(2, list.IndexOf(8));
        Assert.Equal(-1, list.IndexOf(1));
    }

    [Fact]
    public void Test_Contains()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(8);
        list.Add(10);

        Assert.True(list.Contains(8));
        Assert.Equal(-1, list.IndexOf(1));
    }

    [Fact]
    public void Test_RemoveFirst()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(8);

        Assert.False(list.Empty);
        Assert.Equal(3, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveFirst();

        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveFirst();

        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(8, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveFirst();

        Assert.True(list.Empty);
        Assert.Equal(0, list.Size);

        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
    }

    [Fact]
    public void Test_RemoveAt()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(8);
        list.Add(10);

        Assert.False(list.Empty);
        Assert.Equal(4, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(10, list.PeekBack());

        Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(5));

        list.RemoveAt(3);

        Assert.False(list.Empty);
        Assert.Equal(3, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveAt(1);

        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveAt(0);

        Assert.Equal(1, list.Size);
        Assert.Equal(8, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveAt(0);
        Assert.True(list.Empty);
        Assert.Equal(0, list.Size);
    }

    [Fact]
    public void Test_RemoveLast()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(8);

        Assert.False(list.Empty);
        Assert.Equal(3, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.RemoveLast();

        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(5, list.PeekBack());

        list.RemoveLast();

        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(3, list.PeekBack());

        list.RemoveLast();

        Assert.True(list.Empty);
        Assert.Equal(0, list.Size);

        Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
    }

    [Fact]
    public void Test_Remove()
    {
        var list = new DataStructures.DoublyLinkedList<int>();
        list.Add(3);
        list.Add(5);
        list.Add(8);

        Assert.False(list.Empty);
        Assert.Equal(3, list.Size);
        Assert.Equal(3, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.Remove(3);

        Assert.False(list.Empty);
        Assert.Equal(2, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(8, list.PeekBack());

        list.Remove(8);

        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(5, list.PeekBack());

        list.Remove(7);

        Assert.False(list.Empty);
        Assert.Equal(1, list.Size);
        Assert.Equal(5, list.PeekFront());
        Assert.Equal(5, list.PeekBack());

        list.Remove(5);

        Assert.True(list.Empty);
        Assert.Equal(0, list.Size);

        Assert.Throws<InvalidOperationException>(() => list.Remove(5));
    }

    [Fact]
    public void Test_Enumarator()
    {
        var list = new DataStructures.DoublyLinkedList<int>();

        list.AddBack(3);
        list.AddBack(5);
        list.AddBack(8);

        Assert.Collection(list, val => Assert.Equal(3, val), val => Assert.Equal(5, val), val => Assert.Equal(8, val));
    }

    [Fact]
    public void Test_ToString()
    {
        var list = new DataStructures.DoublyLinkedList<int>();

        list.AddBack(3);
        list.AddBack(5);
        list.AddBack(8);

        Assert.Equal("[3, 5, 8]", list.ToString());
    }
}