using System.Collections.Generic;

namespace FontSizeProfiles
{
	public static class DictionaryExtensions
	{
		public static T MergeLeft<T, K, V>(this T me, params IDictionary<K, V>[] others) where T : IDictionary<K, V>, new()
		{
			return default(T);
		}
	}
}
