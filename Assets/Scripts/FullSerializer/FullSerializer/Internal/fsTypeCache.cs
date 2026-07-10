using System;
using System.Collections.Generic;
using System.Reflection;

namespace FullSerializer.Internal
{
	public static class fsTypeCache
	{
		private static Dictionary<string, Type> _cachedTypes;

		private static Dictionary<string, Assembly> _assembliesByName;

		private static List<Assembly> _assembliesByIndex;

		static fsTypeCache()
		{
		}

		private static void OnAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
		}

		private static bool TryDirectTypeLookup(string assemblyName, string typeName, out Type type)
		{
			type = null;
			return false;
		}

		private static bool TryIndirectTypeLookup(string typeName, out Type type)
		{
			type = null;
			return false;
		}

		public static void Reset()
		{
		}

		public static Type GetType(string name)
		{
			return null;
		}

		public static Type GetType(string name, string assemblyHint)
		{
			return null;
		}
	}
}
