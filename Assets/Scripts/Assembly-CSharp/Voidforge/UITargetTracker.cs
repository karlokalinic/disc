using UnityEngine;

namespace Voidforge
{
	public class UITargetTracker : VoidElement
	{
		[SerializeField]
		protected Transform target;

		protected ComponentRef<RectTransform> rectTransform;

		protected bool _isTargetVisible;

		protected OnScreenTrackingTag _trackingTag;

		protected virtual void OnTargetVisibility(bool isVisible)
		{
		}

		protected void OnTrackingEvent()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
