using UnityEngine;
using Voidforge;

namespace IOSCamera
{
	public class iOSZoomController : MonoBehaviour
	{
		public const float DEFAULT_CAMERA_ZOOM = 0.382f;

		private Camera camera;

		private float updateCameraOrthoSizeNextFrame;

		[SerializeField]
		private float zoomValue;

		private float ZoomTargetValue;

		private float touchZoom;

		public OnFloatChangedEvent OnZoomValueChanged;

		[SerializeField]
		private Vector2 zoomLimitsExternal;

		private float cameraDialogeMinatureZoomAddition;

		private bool isDialogMinatureModeActive;

		[SerializeField]
		private Vector2 zoomLimitsInternals;

		private Vector2 currentZoomLimits;

		[SerializeField]
		private AnimationCurve zoomCurve;

		[SerializeField]
		private AnimationCurve ZoomFocusCurve;

		private float cameraSizeSpeed;

		[SerializeField]
		private float zoomSpeed;

		[SerializeField]
		private float zoomScrollWheelSpeed;

		private readonly DSP<float> _mouseScrollWheelZoom;

		public float ZoomValue
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public float TouchZoom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SavedZoomValue { get; private set; }

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnUpdate()
		{
		}

		public void OnLateUpdate()
		{
		}

		public float GetCameraZoom()
		{
			return 0f;
		}

		public void SetCameraZoom(float value)
		{
		}

		public void SetZoomValue(float newZoomValue)
		{
		}

		public Vector3 GetAdjustedCameraPosition(Vector3 cameraPosition, float zoom)
		{
			return default(Vector3);
		}

		public void SetCamera(Camera newCamera)
		{
		}

		public float Get01SavedZoomValue()
		{
			return 0f;
		}

		private float ClampZoom(float value)
		{
			return 0f;
		}

		private Vector2 GetZoomLimiters()
		{
			return default(Vector2);
		}

		public void UpdateZoomLimiters()
		{
		}

		private Vector2 GetUpdatedZoomLimiters()
		{
			return default(Vector2);
		}

		private float GetZoom01(float zoomVal)
		{
			return 0f;
		}

		public void SaveCurrentZoomValue()
		{
		}

		public void RestoreCharacterZoom()
		{
		}

		public void ActivateMinatureMode()
		{
		}

		public void DeactivateMinatureMode()
		{
		}
	}
}
