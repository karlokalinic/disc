using System;
using System.Collections.Generic;

public class GenericObjectPool<T>
{
	protected Func<T> createObjectFunction;

	protected Action<T> onTakenFromPoolAction;

	protected Action<T> onReturnedToPoolAction;

	protected Action<T> onDestroyedAction;

	private readonly Queue<T> pooledObjects;

	private int maxSize;

	private bool collectionCheck;

	public int CountActive { get; private set; }

	public int CountInactive => 0;

	public int CountAll => 0;

	public GenericObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = false, int defaultCapacity = 10, int maxSize = -1)
	{
	}

	private void FillPool(int initialPoolSize = 0)
	{
	}

	protected virtual T CreateElement()
	{
		return default(T);
	}

	protected virtual void OnTakenFromPool(T element)
	{
	}

	protected virtual void OnReturnedToPool(T element)
	{
	}

	protected virtual void OnDestroyedInPool(T element)
	{
	}

	public T Get()
	{
		return default(T);
	}

	public void Release(T element)
	{
	}

	public void Clear()
	{
	}
}
