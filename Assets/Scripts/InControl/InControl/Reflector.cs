using System;
using System.Collections.Generic;

namespace InControl
{
	public static class Reflector
	{
		private static readonly string[] ignoreAssemblies;

		private static IEnumerable<Type> assemblyTypes;

		public static IEnumerable<Type> AllAssemblyTypes => null;

		private static bool IgnoreAssemblyWithName(string assemblyName)
		{
			return false;
		}

		private static IEnumerable<Type> GetAllAssemblyTypes()
		{
			return null;
		}
	}
}
