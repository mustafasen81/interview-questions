namespace Tests;

public class Test_BinarySearchTree
{
    [Fact]
    public void Test_EmptyBST()
    {
        var bst = new DataStructures.BinarySearchTree<int>();

        Assert.True(bst.Empty);
        Assert.Equal(0, bst.Size);
        Assert.Empty(bst);
    }

    [Fact]
    public void Test_Insert()
    {
        var bst = new DataStructures.BinarySearchTree<int>();

        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(3);
        bst.Insert(12);
        bst.Insert(17);

        Assert.False(bst.Empty);
        Assert.Equal(7, bst.Size);
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(10));
        Assert.True(bst.Contains(15));
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(12));
        Assert.True(bst.Contains(17));
        Assert.True(bst.Contains(3));
        Assert.False(bst.Contains(1));
        Assert.Collection(bst, v => Assert.Equal(3, v), v => Assert.Equal(5, v),
         v => Assert.Equal(7, v), v => Assert.Equal(10, v), v => Assert.Equal(12, v),
         v => Assert.Equal(15, v), v => Assert.Equal(17, v));
    }

    [Fact]
    public void Test_Remove()
    {
        var bst = new DataStructures.BinarySearchTree<int>();

        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(3);
        bst.Insert(17);

        Assert.False(bst.Empty);
        Assert.Equal(7, bst.Size);

        bst.Remove(10);
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(15));
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(12));
        Assert.True(bst.Contains(17));
        Assert.True(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.Collection(bst, v => Assert.Equal(3, v), v => Assert.Equal(5, v),
         v => Assert.Equal(7, v), v => Assert.Equal(12, v),
         v => Assert.Equal(15, v), v => Assert.Equal(17, v));

        bst.Remove(5);
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(15));
        Assert.True(bst.Contains(12));
        Assert.True(bst.Contains(17));
        Assert.True(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.False(bst.Contains(5));
        Assert.Collection(bst, v => Assert.Equal(3, v),
         v => Assert.Equal(7, v), v => Assert.Equal(12, v),
         v => Assert.Equal(15, v), v => Assert.Equal(17, v));

        bst.Remove(3);
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(15));
        Assert.True(bst.Contains(12));
        Assert.True(bst.Contains(17));
        Assert.False(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.False(bst.Contains(5));
        Assert.Collection(bst, v => Assert.Equal(7, v), v => Assert.Equal(12, v),
         v => Assert.Equal(15, v), v => Assert.Equal(17, v));

        bst.Remove(17);
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(15));
        Assert.True(bst.Contains(12));
        Assert.False(bst.Contains(17));
        Assert.False(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.False(bst.Contains(5));
        Assert.Collection(bst, v => Assert.Equal(7, v), v => Assert.Equal(12, v), v => Assert.Equal(15, v));

        bst.Remove(12);
        Assert.True(bst.Contains(7));
        Assert.True(bst.Contains(15));
        Assert.False(bst.Contains(12));
        Assert.False(bst.Contains(17));
        Assert.False(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.False(bst.Contains(5));
        Assert.Collection(bst, v => Assert.Equal(7, v), v => Assert.Equal(15, v));

        bst.Remove(15);
        Assert.True(bst.Contains(7));
        Assert.False(bst.Contains(15));
        Assert.False(bst.Contains(12));
        Assert.False(bst.Contains(17));
        Assert.False(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.False(bst.Contains(5));
        Assert.Collection(bst, v => Assert.Equal(7, v));

        bst.Remove(7);
        Assert.False(bst.Contains(7));
        Assert.False(bst.Contains(15));
        Assert.False(bst.Contains(12));
        Assert.False(bst.Contains(17));
        Assert.False(bst.Contains(3));
        Assert.False(bst.Contains(10));
        Assert.False(bst.Contains(5));
        Assert.Empty(bst);

        Assert.True(bst.Empty);
        Assert.Equal(0, bst.Size);
    }

    [Fact]
    public void Test_PreOrderTraversal()
    {
        var bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(3);
        bst.Insert(17);

        Assert.Collection(bst.PreOrderTraversal(),
        v => Assert.Equal(10, v),
        v => Assert.Equal(5, v),
        v => Assert.Equal(3, v),
        v => Assert.Equal(7, v),
        v => Assert.Equal(15, v),
        v => Assert.Equal(12, v),
        v => Assert.Equal(17, v));
    }

    [Fact]
    public void Test_InOrderTraversal()
    {
        var bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(3);
        bst.Insert(17);

        Assert.Collection(bst.InOrderTraversal(),
        v => Assert.Equal(3, v),
        v => Assert.Equal(5, v),
        v => Assert.Equal(7, v),
        v => Assert.Equal(10, v),
        v => Assert.Equal(12, v),
        v => Assert.Equal(15, v),
        v => Assert.Equal(17, v));
    }

    [Fact]
    public void Test_PostOrderTraversal()
    {
        var bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(3);
        bst.Insert(17);

        Assert.Collection(bst.PostOrderTraversal(),
        v => Assert.Equal(3, v),
        v => Assert.Equal(7, v),
        v => Assert.Equal(5, v),
        v => Assert.Equal(12, v),
        v => Assert.Equal(17, v),
        v => Assert.Equal(15, v),
        v => Assert.Equal(10, v));
    }

    [Fact]
    public void Test_LevelOrderTraversal()
    {
        var bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(3);
        bst.Insert(17);

        Assert.Collection(bst.LevelOrderTraversal(),
        v => Assert.Equal(10, v),
        v => Assert.Equal(5, v),
        v => Assert.Equal(15, v),
        v => Assert.Equal(3, v),
        v => Assert.Equal(7, v),
        v => Assert.Equal(12, v),
        v => Assert.Equal(17, v));
    }

    [Fact]
    public void Test_Height()
    {
        var bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(3);
        bst.Insert(17);

        Assert.Equal(3, bst.Height);

        bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(3);
        bst.Insert(5);
        bst.Insert(7);
        bst.Insert(10);
        bst.Insert(12);
        bst.Insert(15);
        bst.Insert(17);
        Assert.Equal(7, bst.Height);

        bst = new DataStructures.BinarySearchTree<int>();
        bst.Insert(17);
        bst.Insert(15);
        bst.Insert(12);
        bst.Insert(10);
        bst.Insert(7);
        bst.Insert(5);
        bst.Insert(3);
        Assert.Equal(7, bst.Height);
    }
}