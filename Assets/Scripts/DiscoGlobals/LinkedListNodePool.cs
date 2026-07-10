using System.Collections.Generic;

public class LinkedListNodePool<T> : BasePool<LinkedListNode<T>> where T : class
{
	public LinkedListNodePool(int capacity)
		: base(0)
	{
	}

	protected override object New()
	{
		return null;
	}
}
