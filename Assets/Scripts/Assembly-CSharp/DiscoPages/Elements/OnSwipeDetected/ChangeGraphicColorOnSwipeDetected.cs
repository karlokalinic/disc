using DiscoPages.Elements.Common;
using UnityEngine;
using UnityEngine.UI;

namespace DiscoPages.Elements.OnSwipeDetected
{
	public class ChangeGraphicColorOnSwipeDetected : OnSwipeDetected
	{
		[SerializeField]
		private Graphic targetUIElement;

		[SerializeField]
		private Color targetColor;

		[SerializeField]
		private float distanceValueToFullColor;

		[SerializeField]
		private bool alwaysChangeColorIfIsDrag;

		[SerializeField]
		private SwipeDetector.SwipeDirection swipeDirectionToActivate;

		private Color baseColor;

		protected override void Reset()
		{
		}

		private void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		public void ResetColor()
		{
		}

		protected override void DetectSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
