using System.Collections.Generic;

public class ArrayPool<T>
{
	private Dictionary<object, bool> tracker;

	private Dictionary<int, Queue<T[]>> pool;

	public ArrayPool(int capacity)
	{
	}

	private Queue<T[]> GetQueue(int length)
	{
		return null;
	}

	public T[] Get(int length)
	{
		return null;
	}

	public void Return(T[] array)
	{
	}
}
