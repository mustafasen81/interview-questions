namespace DataStructures;

public class HashTable<K, V> where K : notnull
{
    private class Entry
    {
        public K Key { get; }
        public V? Value { get; }

        public Entry(K key, V? value)
        {
            Key = key;
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            var entry = obj as Entry;
            return entry != null && Key.Equals(entry.Key);
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }

    private readonly int Capacity = 1000;

    private readonly System.Collections.Generic.LinkedList<Entry>[] Table;

    public HashTable()
    {
        Table = new System.Collections.Generic.LinkedList<Entry>[Capacity];
    }

    private int GetTableIndex(K key)
    {
        var hashCode = key.GetHashCode();
        return hashCode % Capacity;
    }

    public void Insert(K key, V value)
    {
        int index = GetTableIndex(key);
        if (Table[index] != null)
        {
            Table[index].AddLast(new Entry(key, value));
        }
        else
        {
            Table[index] = new System.Collections.Generic.LinkedList<Entry>(new Entry[] { new Entry(key, value) });
        }
        Size++;
    }

    public V? Get(K key)
    {
        int index = GetTableIndex(key);
        if (Table[index] == null)
        {
            return default(V);
        }
        var entry = Table[index].FirstOrDefault(i => i.Key.Equals(key));
        return entry == default(Entry) ? default(V) : entry.Value;
    }

    public V? Remove(K key)
    {
        int index = GetTableIndex(key);
        if (Table[index] != null)
        {
            var node = Table[index].Find(new Entry(key, default(V)));
            if (node != null)
            {
                Table[index].Remove(node);
                Size--;
                return node.Value.Value;
            }
        }
        return default(V);
    }

    public int Size { get; private set; }

    public bool Empty { get => Size == 0; }
}