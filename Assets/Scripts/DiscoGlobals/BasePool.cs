using System.Collections.Generic;

public abstract class BasePool<T> : IPool
{
	private int capacity;

	private Dictionary<T, bool> tracker;

	private Queue<T> queue;

	public override int Capacity => 0;

	public override int FreeCount => 0;

	public BasePool(int capacity)
	{
	}

	protected override void ExpandCapacity(int newCapacity)
	{
	}

	public override object Get()
	{
		return null;
	}

	public override void Return(object obj)
	{
	}
}
