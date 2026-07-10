using UnityEngine;

namespace PixelCrushers
{
	public class CollisionEvent : TagMaskEvent
	{
		[SerializeField]
		private GameObjectUnityEvent m_onCollisionEnter;

		[SerializeField]
		private GameObjectUnityEvent m_onCollisionExit;

		public GameObjectUnityEvent onCollisionEnter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObjectUnityEvent onCollisionExit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		protected virtual void OnCollisionExit(Collision collision)
		{
		}
	}
}
