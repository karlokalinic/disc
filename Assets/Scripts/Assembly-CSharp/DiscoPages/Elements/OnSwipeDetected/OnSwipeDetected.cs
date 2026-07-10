using DiscoPages.Elements.Common;
using UnityEngine;

namespace DiscoPages.Elements.OnSwipeDetected
{
	public abstract class OnSwipeDetected : MonoBehaviour
	{
		[SerializeField]
		private SwipeDetector localSwipeDetector;

		public bool Active;

		protected bool UsesLocalSwipe => false;

		protected virtual void Reset()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected abstract void DetectSwipe(SwipeDetector.SwipeData data);
	}
}
