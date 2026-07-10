using UnityEngine;

namespace Voidforge
{
	public class ComponentInstancePool<T> : InstancePool where T : Component
	{
		public override bool IsHandler<S>(string prefabId)
		{
			return false;
		}

		protected override Transform Create()
		{
			return null;
		}
	}
}
