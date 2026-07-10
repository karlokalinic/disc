using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class InstanceFactory : SingletonClass<InstanceFactory>
	{
		protected HashSet<InstancePool> instancePools;

		public static GameObject Create(string prefabId)
		{
			return null;
		}

		public static T Create<T>(string prefabId) where T : Component
		{
			return null;
		}

		public static T Create<T>() where T : Component
		{
			return null;
		}

		public static bool Register(InstancePool pool)
		{
			return false;
		}

		public static bool UnRegister(InstancePool pool)
		{
			return false;
		}
	}
}
