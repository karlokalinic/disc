using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class InstanceKeeperTag<T> : VoidTag where T : Object
	{
		protected HashSet<T> instances;

		public void Register(T item)
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
