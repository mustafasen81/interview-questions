using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures;

public class LinkedList<T> : IEnumerable<T?>
{
    private class Node
    {
        public T? Data { get; set; }
        public Node? Next { get; set; }
    }

    private Node? Head { get; set; } = null;
    private Node? Tail { get; set; } = null;

    public LinkedList()
    {

    }

    public int Size { get; private set; }

    [MemberNotNullWhen(returnValue: false, nameof(Head))]
    [MemberNotNullWhen(returnValue: false, nameof(Tail))]
    public bool Empty
    {
        get
        {
            return Size == 0;
        }
    }

    public void Clear()
    {
        Head = null;
        Size = 0;
    }

    public T? PeekFront()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }
        return Head.Data;
    }

    public T? PeekBack()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }
        return Tail.Data;
    }

    public void Add(T? data)
    {
        AddBack(data);
    }

    public void AddFront(T? data)
    {
        if (Empty)
        {
            Tail = Head = new Node() { Data = data };
        }
        else
        {
            Head = new Node() { Data = data, Next = Head };
        }
        Size++;
    }

    public void AddBack(T? data)
    {
        if (Empty)
        {
            Tail = Head = new Node() { Data = data };
        }
        else
        {
            Tail.Next = new Node() { Data = data };
            Tail = Tail.Next;
        }
        Size++;
    }


    public void Remove(T? data)
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }

        if (Equals(data, Head))
        {
            RemoveFront();
            return;
        }

        var current = Head;
        while (current.Next != null)
        {
            if (Equals(data, current.Next))
            {
                RemoveNext(current);
                break;
            }
            current = current.Next;
        }
    }

    public void RemoveBack()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }
        RemoveAt(Size - 1);
    }

    public void RemoveFront()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }
        Head = Head.Next;
        if (Head == null || Head.Next == null)
        {
            Tail = Head;
        }
        Size--;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Size)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            RemoveFront();
        }

        var current = Head;
        while (current != null)
        {
            if (index == 1)
            {
                RemoveNext(current);
            }
            index--;
            current = current.Next;
        }
    }

    private void RemoveNext(Node node)
    {
        if (node.Next != null)
        {
            node.Next = node.Next.Next;
            if (node.Next == null)
            {
                Tail = node;
            }
            Size--;
        }
    }

    public int IndexOf(T? data)
    {
        var current = Head;
        int index = 0;
        while (current != null)
        {
            if (Equals(data, current))
            {
                return index;
            }
            current = current.Next;
            index++;
        }
        return -1;
    }

    private bool Equals(T? data, Node node)
    {
        if (data == null)
        {
            return node.Data == null;
        }
        else
        {
            return data.Equals(node.Data);
        }
    }

    public bool Contains(T? data)
    {
        return IndexOf(data) != -1;
    }

    public IEnumerator<T?> GetEnumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("[");
        var enumarator = GetEnumerator();
        if (enumarator.MoveNext())
        {
            sb.Append(enumarator.Current);
        }

        while (enumarator.MoveNext())
        {
            sb.Append(", ").Append(enumarator.Current);

        }

        sb.Append("]");

        return sb.ToString();
    }
}
