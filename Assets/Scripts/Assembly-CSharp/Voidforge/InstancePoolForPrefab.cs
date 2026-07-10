using System;
using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class InstancePoolForPrefab : InstancePool
	{
		[SerializeField]
		protected Transform prefab;

		protected string cachedPrefabId;

		protected HashSet<Type> cachedPrefabComponentTypes;

		public override bool IsHandler<T>(string prefabId)
		{
			return false;
		}

		protected override Transform Create()
		{
			return null;
		}

		protected override void Initialize(Transform t)
		{
		}
	}
}
