using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public struct ComponentRegistry<T> where T : Component
	{
		private HashSet<T> registry;

		public int Count => 0;

		public T Find(Predicate<T> Condition)
		{
			return null;
		}

		public void ForEach(Action<T> Action)
		{
		}

		public bool Register(T component)
		{
			return false;
		}

		public bool Unregister(T component)
		{
			return false;
		}
	}
	public struct ComponentRegistry<K, T> where T : Component
	{
		private Dictionary<K, T> registry;

		public T Item => null;

		public int Count => 0;

		public T Get(K key)
		{
			return null;
		}

		public T Find(Predicate<T> Condition)
		{
			return null;
		}

		public void ForEach(Action<T> Action)
		{
		}

		public bool Register(K key, T component)
		{
			return false;
		}

		public bool Unregister(K key)
		{
			return false;
		}
	}
}
