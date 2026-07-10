using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class FloatResizer : CameraTrackingTagListener
	{
		[SerializeField]
		protected AnimationCurve floatScale;

		protected ComponentRef<RectTransform> rectTransform;

		protected float baseScale;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void SetParameters(float zoom)
		{
		}
	}
}
