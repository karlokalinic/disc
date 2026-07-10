using UnityEngine;

namespace Voidforge
{
	public class CameraTrackingTag : PositionTrackingTag
	{
		public Camera[] Camera;

		protected float cachedFOV;

		protected Rect cachedViewport;

		protected float fov => 0f;

		protected override void OnEnable()
		{
		}

		protected override void LateUpdate()
		{
		}
	}
}
