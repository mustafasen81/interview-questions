using System.Collections;

namespace DataStructures;

public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable<T>
{
    class Node
    {
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }

    private Node? Root { get; set; }

    private void Insert(Node node, T data)
    {
        if (data.CompareTo(node.Data) < 0)
        {
            if (node.Left == null)
            {
                node.Left = new Node(data);
            }
            else
            {
                Insert(node.Left, data);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new Node(data);
            }
            else
            {
                Insert(node.Right, data);
            }
        }
    }

    private Tuple<Node?, Node?> Find(Node? parent, Node? node, T data)
    {
        if (node == null)
        {
            return new Tuple<Node?, Node?>(null, null);
        }
        var result = data.CompareTo(node.Data);
        if (result < 0)
        {
            return Find(node, node.Left, data);
        }
        if (result > 0)
        {
            return Find(node, node.Right, data);
        }
        return new Tuple<Node?, Node?>(parent, node);
    }

    private void Remove(Node? parent, Node node)
    {
        if (node.Left != null && node.Right != null)
        {
            var (parentOfSmallest, smallestNode) = FindSmallest(node, node.Right);
            node.Data = smallestNode.Data;
            Remove(parentOfSmallest, smallestNode);
        }
        else if (node.Left != null)
        {
            Node temp = node.Left;
            node.Data = temp.Data;
            node.Left = temp.Left;
            node.Right = temp.Right;
        }
        else if (node.Right != null)
        {
            Node temp = node.Right;
            node.Data = temp.Data;
            node.Left = temp.Left;
            node.Right = temp.Right;
        }
        else if (parent == null)
        {
            Root = null;
        }
        else if (parent.Left == node)
        {
            parent.Left = null;
        }
        else
        {
            parent.Right = null;
        }
    }

    private Tuple<Node, Node> FindSmallest(Node parent, Node node)
    {
        if (node.Left == null)
        {
            return new Tuple<Node, Node>(parent, node);
        }
        return FindSmallest(node, node.Left);
    }

    private IEnumerable<T> PreOrderTraversal(Node node)
    {
        yield return node.Data;

        if (node.Left != null)
        {
            foreach (var data in PreOrderTraversal(node.Left))
            {
                yield return data;
            }
        }

        if (node.Right != null)
        {
            foreach (var data in PreOrderTraversal(node.Right))
            {
                yield return data;
            }
        }
    }

    private IEnumerable<T> InOrderTraversal(Node node)
    {
        if (node.Left != null)
        {
            foreach (var data in InOrderTraversal(node.Left))
            {
                yield return data;
            }
        }

        yield return node.Data;

        if (node.Right != null)
        {
            foreach (var data in InOrderTraversal(node.Right))
            {
                yield return data;
            }
        }
    }

    private IEnumerable<T> PostOrderTraversal(Node node)
    {
        if (node.Left != null)
        {
            foreach (var data in PostOrderTraversal(node.Left))
            {
                yield return data;
            }
        }

        if (node.Right != null)
        {
            foreach (var data in PostOrderTraversal(node.Right))
            {
                yield return data;
            }
        }

        yield return node.Data;
    }

    private int HeightInternal(Node? root)
    {
        if (root == null)
        {
            return 0;
        }
        int leftHeight = HeightInternal(root.Left);
        int rightHeight = HeightInternal(root.Right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    public void Insert(T data)
    {
        if (Root == null)
        {
            Root = new Node(data);
        }
        else
        {
            Insert(Root, data);
        }
        Size++;
    }

    public bool Contains(T data)
    {
        var (_, node) = Find(null, Root, data);
        return node != null;
    }

    public void Remove(T data)
    {
        var (parent, node) = Find(null, Root, data);
        if (node != null)
        {
            Remove(parent, node);
            Size--;
        }
    }

    public IEnumerable<T> PreOrderTraversal()
    {
        if (Root != null)
        {
            foreach (var data in PreOrderTraversal(Root))
            {
                yield return data;
            }
        }
    }

    public IEnumerable<T> InOrderTraversal()
    {
        if (Root != null)
        {
            foreach (var data in InOrderTraversal(Root))
            {
                yield return data;
            }
        }
    }

    public IEnumerable<T> PostOrderTraversal()
    {
        if (Root != null)
        {
            foreach (var data in PostOrderTraversal(Root))
            {
                yield return data;
            }
        }
    }

    public IEnumerable<T> LevelOrderTraversal()
    {
        if (Root != null)
        {
            var nodes = new System.Collections.Generic.Queue<Node>();
            nodes.Enqueue(Root);
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                if (node.Left != null)
                {
                    nodes.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    nodes.Enqueue(node.Right);
                }
                yield return node.Data;
            }
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var data in InOrderTraversal())
        {
            yield return data;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Size { get; private set; } = 0;

    public bool Empty { get => Size == 0; }

    public int Height { get => HeightInternal(Root); }

}