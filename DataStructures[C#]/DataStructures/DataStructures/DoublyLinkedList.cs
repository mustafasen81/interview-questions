namespace DataStructures;

public class DoublyLinkedList<T>
{
    private class Node
    {
        public T? Data { get; set; }
        public Node? Next { get; set; }
    }

    private Node? head = null;

    public DoublyLinkedList()
    {

    }

    public int Size { get; private set; }

    public bool Empty
    {
        get
        {
            return Size == 0;
        }
    }

    public void Clear()
    {
        head = null;
        Size = 0;
    }

    // public void Add(T data)
    // {

    // }

    // public void AddFirst(T data)
    // {

    // }

    // public void AddLast(T data)
    // {

    // }

    // public T PeekFirst()
    // {

    // }

    // public T PeekLast()
    // {

    // }

    // public void Remove(T data)
    // {

    // }

    // public void RemoveFirst()
    // {

    // }

    // public void RemoveLast()
    // {

    // }

    // public void RemoveAt(int index)
    // {

    // }

    // public int IndexOf(T data)
    // {

    // }

    // public bool Contains(T data)
    // {

    // }
}
