using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voidforge
{
	public abstract class ObservedValue
	{
		[SerializeField]
		protected string _name;

		[SerializeField]
		protected string _path;

		[SerializeField]
		protected Operation _operations;

		public Operation logOperations
		{
			get
			{
				return default(Operation);
			}
			set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Log(Operation op, string message = null)
		{
		}

		public ObservedValue()
		{
		}

		public ObservedValue(Operation operations, string fullName)
		{
		}
	}
	public abstract class ObservedValue<T> : ObservedValue
	{
		[SerializeField]
		protected T _value;

		public T value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public event Action<T> GetEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<T, T> SetEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ObservedValue()
		{
		}

		public ObservedValue(Operation operations, string fullName)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator T(ObservedValue<T> obsValue)
		{
			return default(T);
		}
	}
}
