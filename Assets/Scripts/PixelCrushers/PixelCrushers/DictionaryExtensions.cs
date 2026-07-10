using System;
using System.Collections.Generic;

namespace PixelCrushers
{
	public static class DictionaryExtensions
	{
		public static int RemoveAll<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Predicate<TKey> match)
		{
			return 0;
		}
	}
}
