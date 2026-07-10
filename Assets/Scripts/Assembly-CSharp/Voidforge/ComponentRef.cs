using System;
using UnityEngine;

namespace Voidforge
{
	public struct ComponentRef<T> : IComponentRef where T : Component
	{
		private Component container;

		private GetComponentAttribute config;

		private T[] references;

		public T Item => null;

		public int Count => 0;

		public T Random => null;

		public void Clear()
		{
		}

		public void FilterBy(Predicate<T> Condition)
		{
		}

		public void ForEach(Action<T> Action)
		{
		}

		public void Initialize(Component container, GetComponentAttribute attr)
		{
		}

		public static implicit operator T(ComponentRef<T> c)
		{
			return null;
		}

		public static implicit operator bool(ComponentRef<T> c)
		{
			return false;
		}
	}
}
