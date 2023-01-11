using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructures;

public class DoublyLinkedList<T> : IEnumerable<T?>
{
    private class Node
    {
        public T? Data { get; set; }
        public Node? Next { get; set; }
        public Node? Prev { get; set; }
    }

    private Node? Head { get; set; } = null;
    private Node? Tail { get; set; } = null;

    public DoublyLinkedList()
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
        Tail = null;
        Size = 0;
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

    public void Add(T? data)
    {
        AddBack(data);
    }

    public void AddFront(T? data)
    {
        if (Empty)
        {
            Head = Tail = new Node() { Data = data };
        }
        else
        {
            Head = new Node() { Data = data, Next = Head };
            Head.Next.Prev = Head;
        }
        Size++;
    }

    public void AddBack(T? data)
    {
        if (Empty)
        {
            Head = Tail = new Node() { Data = data };
        }
        else
        {
            Tail = new Node() { Data = data, Prev = Tail };
            Tail.Prev.Next = Tail;
        }
        Size++;
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

    public void Remove(T? data)
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }

        var current = Head;
        while (current != null)
        {
            if (Equals(data, current))
            {
                Remove(current);
                break;
            }
            current = current.Next;
        }
    }

    private void Remove(Node current)
    {
        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }
        else
        {
            Head = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }
        else
        {
            Tail = current.Prev;
        }
        Size--;
    }

    public void RemoveFirst()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }
        Remove(Head);
    }

    public void RemoveLast()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty list.");
        }
        Remove(Tail);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Size)
        {
            throw new IndexOutOfRangeException();
        }

        var current = Head;
        while (current != null)
        {
            if (index == 0)
            {
                Remove(current);
                break;
            }
            current = current.Next;
            index--;
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
            index++;
            current = current.Next;
        }
        return -1;
    }

    public bool Contains(T? data)
    {
        return IndexOf(data) != -1;
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
