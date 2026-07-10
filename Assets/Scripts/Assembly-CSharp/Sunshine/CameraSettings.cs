using FortressOccident;
using UnityEngine;

namespace Sunshine
{
	public abstract class CameraSettings : FOComponent
	{
		[SerializeField]
		protected bool setZoom;

		[SerializeField]
		public float zoom;

		[SerializeField]
		protected bool setViewport;

		[SerializeField]
		public Vector2 viewport;

		protected void SetCameraControllerValues(Vector3 position, bool noTween)
		{
		}
	}
}
