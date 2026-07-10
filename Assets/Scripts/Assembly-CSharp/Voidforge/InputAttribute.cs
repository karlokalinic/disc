using System;

namespace Voidforge
{
	public abstract class InputAttribute : Attribute
	{
		protected int? _priority;

		public bool hasPriority => false;

		public int priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public InputAttribute()
		{
		}
	}
}
