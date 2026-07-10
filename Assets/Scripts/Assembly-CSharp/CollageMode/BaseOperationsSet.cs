using System;
using UnityEngine;

namespace CollageMode
{
	public abstract class BaseOperationsSet : ScriptableObject
	{
		public virtual Operation[] Operations { get; }

		public Type OperationsType => null;

		public int Count => 0;

		public Operation Item => null;

		public virtual void Initialize()
		{
		}
	}
}
