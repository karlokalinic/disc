using System.Collections.Generic;

public class MruDictionary<Key, Value>
{
	private int capacity;

	private Queue<LinkedListNode<KeyValuePair<Key, Value>>> recycled;

	private LinkedList<KeyValuePair<Key, Value>> list;

	private Dictionary<Key, LinkedListNode<KeyValuePair<Key, Value>>> dict;

	public int Count => 0;

	public int Capacity => 0;

	public MruDictionary(int capacity)
	{
	}

	public void Clear()
	{
	}

	public void Add(Key key, Value value)
	{
	}

	public KeyValuePair<Key, Value> GetLast()
	{
		return default(KeyValuePair<Key, Value>);
	}

	public void RemoveLast()
	{
	}

	public bool TryGetValue(Key key, out Value value)
	{
		value = default(Value);
		return false;
	}

	public bool Touch(Key key)
	{
		return false;
	}
}
