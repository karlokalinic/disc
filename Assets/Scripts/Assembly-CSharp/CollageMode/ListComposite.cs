using System;
using System.Collections.Generic;

namespace CollageMode
{
	public class ListComposite<T>
	{
		private List<T>[] lists;

		public int Count => 0;

		public T Item => default(T);

		public ListComposite(params List<T>[] lists)
		{
		}

		public int IndexOf(T t)
		{
			return 0;
		}

		public int FindIndex(Predicate<T> predicate)
		{
			return 0;
		}
	}
}
