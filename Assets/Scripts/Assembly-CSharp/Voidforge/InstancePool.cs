using UnityEngine;

namespace Voidforge
{
	public abstract class InstancePool : VoidElement
	{
		public class Tag : VoidTag
		{
			protected InstancePool _instancePool;

			public void Initialize(InstancePool pool)
			{
			}

			public bool Recycle()
			{
				return false;
			}
		}

		public int maxSize;

		public GameObject Acquire()
		{
			return null;
		}

		public virtual bool IsHandler<T>(string prefabId) where T : Component
		{
			return false;
		}

		protected bool Recycle(GameObject obj)
		{
			return false;
		}

		protected abstract Transform Create();

		protected virtual void Initialize(Transform t)
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}
	}
}
