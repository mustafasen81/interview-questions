using System.Collections;

namespace DataStructures;

public class Stack<T> : IEnumerable<T?>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Push(T? data)
    {
        list.AddFront(data);
    }

    public T? Peek()
    {
        return list.PeekFront();
    }

    public T? Pop()
    {
        var data = Peek();
        list.RemoveFront();
        return data;
    }

    public IEnumerator<T?> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Empty
    {
        get
        {
            return list.Empty;
        }
    }

    public int Size
    {
        get
        {
            return list.Size;
        }
    }

}