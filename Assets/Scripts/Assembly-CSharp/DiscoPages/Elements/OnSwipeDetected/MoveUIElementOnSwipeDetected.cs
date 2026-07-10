using DiscoPages.Elements.Common;
using UnityEngine;

namespace DiscoPages.Elements.OnSwipeDetected
{
	public class MoveUIElementOnSwipeDetected : OnSwipeDetected
	{
		[SerializeField]
		private RectTransform targetUIElement;

		[SerializeField]
		private float reachTargetSpeed;

		[SerializeField]
		private Vector2 minMaxX;

		[SerializeField]
		private Vector2 minMaxY;

		private Vector2 basePosition;

		private Vector2 nextTargetPosition;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void DetectSwipe(SwipeDetector.SwipeData data)
		{
		}
	}
}
