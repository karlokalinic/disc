using System.Collections;
using FortressOccident;
using IOSCamera;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class TweenCamera : Tween
	{
		[SerializeField]
		protected float duration;

		public float easingFactor;

		[SerializeField]
		protected Vector3 focus;

		[SerializeField]
		protected float zoom;

		[SerializeField]
		protected Vector2 viewportFocus;

		protected Vector3? initialFocus;

		protected float? initialZoom;

		protected Vector2? initialViewport;

		protected ComponentRef<CameraController> cameraController;

		protected ComponentRef<iOSCameraControllerTest> iOScameraController;

		private Coroutine cameraTweenCoroutine;

		private Vector3 _origDuration;

		public Vector3 Durations
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Focus
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Zoom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 ViewportFocus
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		protected bool setZoomFactor => false;

		public override void Play()
		{
		}

		public void Play(float duration, float delayStart = 0f, float delayEnd = 0f)
		{
		}

		public void RestoreOriginalDurationAndStopCoroutine()
		{
		}

		protected IEnumerator PlayCoR(Vector3 durations)
		{
			return null;
		}

		protected override void Repaint()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
