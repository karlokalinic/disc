using DiscoPages.Elements.Common;
using UnityEngine;
using UnityEngine.Events;

namespace DiscoPages.Elements.OnSwipeDetected
{
	public class EventOnSwipeDetected : OnSwipeDetected
	{
		[SerializeField]
		private bool activateOnDragEnd;

		[SerializeField]
		private float distanceValueToActivate;

		public UnityEvent OnUpSwipe;

		public UnityEvent OnDownSwipe;

		public UnityEvent OnLeftSwipe;

		public UnityEvent OnRightSwipe;

		protected override void Reset()
		{
		}

		protected override void DetectSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
