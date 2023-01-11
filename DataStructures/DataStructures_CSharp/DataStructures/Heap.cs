namespace DataStructures;

public class Heap<T> where T : IComparable<T>
{
    private List<T> storage = new List<T>();
    private Dictionary<T, List<int>> valueToIndexMap = new Dictionary<T, List<int>>();

    private int LeftChild(int root)
    {
        int child = 2 * root + 1;
        return child < storage.Count ? child : -1;
    }

    private int RightChild(int root)
    {
        int child = 2 * root + 2;
        return child < storage.Count ? child : -1;
    }

    private int Root(int child)
    {
        return (child - 1) / 2;
    }

    private void Swap(int node1, int node2)
    {
        var temp = storage[node1];
        storage[node1] = storage[node2];
        storage[node2] = temp;
        valueToIndexMap[storage[node1]].Add(node1);
        valueToIndexMap[storage[node2]].Add(node2);
        valueToIndexMap[storage[node1]].Remove(node2);
        valueToIndexMap[storage[node2]].Remove(node1);
    }

    private void BubbleUp(int node)
    {
        int current = node;
        while (current != 0)
        {
            int root = Root(current);
            if (storage[current].CompareTo(storage[root]) < 0)
            {
                Swap(current, root);
                current = root;
            }
            else
            {
                break;
            }
        }
    }

    private void BubbleDown(int node)
    {
        int current = node;
        int leftChild = LeftChild(current);
        int rightChild = RightChild(current);
        while (leftChild >= 0)
        {
            int minChild = leftChild;
            if (rightChild != -1 && storage[rightChild].CompareTo(storage[minChild]) < 0)
            {
                minChild = rightChild;
            }
            if (storage[minChild].CompareTo(storage[current]) < 0)
            {
                Swap(current, minChild);
                current = minChild;
                leftChild = LeftChild(current);
                rightChild = RightChild(current);
            }
            else
            {
                break;
            }
        }
    }

    private void RemoveAt(int index)
    {
        if (index < 0 && index >= storage.Count)
        {
            throw new IndexOutOfRangeException();
        }

        int last = storage.Count - 1;
        Swap(index, last);
        storage.RemoveAt(last);
        BubbleDown(index);
    }

    public int Size { get { return storage.Count; } }

    public bool Empty { get { return Size == 0; } }

    public void Insert(T data)
    {
        storage.Add(data);
        if (valueToIndexMap.ContainsKey(data))
        {
            valueToIndexMap[data].Add(storage.Count - 1);
        }
        else
        {
            valueToIndexMap.Add(data, new List<int>(new int[] { storage.Count - 1 }));
        }
        BubbleUp(storage.Count - 1);
    }

    public T Poll()
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty heap.");
        }
        var data = storage[0];
        RemoveAt(0);
        return data;
    }

    public void Remove(T data)
    {
        if (Empty)
        {
            throw new InvalidOperationException("Empty heap.");
        }
        if (valueToIndexMap.ContainsKey(data))
        {
            int index = valueToIndexMap[data].First();
            RemoveAt(index);
        }
    }
}