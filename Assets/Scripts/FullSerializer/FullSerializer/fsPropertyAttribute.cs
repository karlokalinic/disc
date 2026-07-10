using System;

namespace FullSerializer
{
	public sealed class fsPropertyAttribute : Attribute
	{
		public string Name;

		public Type Converter;

		public fsPropertyAttribute()
		{
		}

		public fsPropertyAttribute(string name)
		{
		}
	}
}
