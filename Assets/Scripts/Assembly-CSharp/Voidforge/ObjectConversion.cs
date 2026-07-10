using System.Collections.Generic;

namespace Voidforge
{
	public static class ObjectConversion
	{
		public static T Convert<T>(this object obj)
		{
			return default(T);
		}

		public static void Shuffle<T>(this List<T> list)
		{
		}
	}
}
