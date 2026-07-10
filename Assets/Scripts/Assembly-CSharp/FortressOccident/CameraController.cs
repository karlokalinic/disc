using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sunshine;
using Sunshine.Views;
using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class CameraController : FOComponent
	{
		public class CameraRestorePoint
		{
			public float RestoreZoomValue;

			public Vector2 RestoreViewpointFocusValue;

			public CameraRestorePoint(float zoomFactor, Vector2 viewportFocus)
			{
			}

			public void UpdateValues(float zoomFactor, Vector2 viewportFocus)
			{
			}

			public void UpdateValuesDebug(float zoomFactor, Vector2 viewportFocus)
			{
			}
		}

		public Dictionary<ViewType, CameraRestorePoint> CameraRestorePoints;

		public CameraRestorePoint DefaultCameraRestorePoint;

		public ScreenPointToRay screenPointToRay;

		[SerializeField]
		private bool isSlaved;

		[SerializeField]
		private float panSpeed;

		[SerializeField]
		private Vector2 panSpeedVector;

		[SerializeField]
		private AnimationCurve ZoomFocusCurve;

		[SerializeField]
		private Vector2 zoomFocusLimits;

		[SerializeField]
		private Vector2 viewportFocus;

		[SerializeField]
		private AnimationCurve zoomCurve;

		[SerializeField]
		private float zoomValue;

		[SerializeField]
		private Vector2 zoomLimitsExt;

		[SerializeField]
		private Vector2 zoomLimitsInt;

		[SerializeField]
		private float zoomSpeed;

		[SerializeField]
		private float zoomScrollWheelSpeed;

		[SerializeField]
		private bool zoomScrollWheelSmoothing;

		[SerializeField]
		private bool jitterKiller;

		private Camera _camera;

		[SerializeField]
		private Vector2 maxZoomScreenPosition;

		[SerializeField]
		private Vector2 minZoomScreenPosition;

		private Vector2 currentZoomLimits;

		[SerializeField]
		private HashSet<object> cameraLocks;

		private ICameraBackPosition dialogueCameraMarker;

		private ComponentRef<TweenCamera> cameraTween;

		[SerializeField]
		private Vector2 currentViewportFocus;

		private Vector2 lastMousePosition;

		private Vector2 panDelta;

		private float updateCameraOrthoSize;

		private Vector3 specialFocus;

		private float specialZoom;

		private Vector2 specialViewportFocus;

		private bool thoughtCabinetActive;

		private float touchZoom;

		private readonly DSP<float> _mouseScrollWheelZoom;

		private DoubleClickDetector doubleZoomClick;

		[SerializeField]
		private bool isCameraFocusingOnInventory;

		public static Camera Camera => null;

		public static CameraController Current { get; private set; }

		public bool IsCameraFocusingOnInventory => false;

		public Vector3 GetCurrentZoomLimits => default(Vector3);

		public bool SpecialSlave { get; private set; }

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

		public Vector2 ScreenFocus
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 ViewportFocus => default(Vector2);

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

		public float ZoomFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsLocked => false;

		public bool IsSlaved
		{
			get
			{
				return false;
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

		public static event Action<CameraController> LockedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnCameraMove
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public float RestoreZoomValue(ViewType viewType)
		{
			return 0f;
		}

		public Vector2 RestoreViewpointFocusValue(ViewType viewType)
		{
			return default(Vector2);
		}

		protected override void Awake()
		{
		}

		public void Start()
		{
		}

		public static float GetZoomInOutValue()
		{
			return 0f;
		}

		private void Update()
		{
		}

		public void LateUpdate()
		{
		}

		private void Refocus()
		{
		}

		public bool AddLock(object lockObj)
		{
			return false;
		}

		public bool CheckLock(object lockObj)
		{
			return false;
		}

		public void SetSpecialSlave(bool value, bool isTHC, Vector3 focus = default(Vector3), float zoom = 0f, Vector2 viewportFocus = default(Vector2))
		{
		}

		public bool RemoveLock(object lockObj)
		{
			return false;
		}

		public bool RemoveAllLocksAndCenterViewport()
		{
			return false;
		}

		public void SetFocus(Vector3 newPosition)
		{
		}

		public void SetFocus(Vector3 newPosition, float? newZoomFactor, bool instant)
		{
		}

		private void FinishTween()
		{
		}

		public void SetViewportAndFocus(Vector2 newFocus, Vector3 newPosition, float? newZoomFactor = null, bool instant = false)
		{
		}

		public void SetFocusAndViewport(Vector3 newPosition, float? newZoomFactor, bool instant, Vector2 newFocus)
		{
		}

		private void OnZoomFactorChange(float value, bool fromMouseWheel = false)
		{
		}

		public float GetZoom01()
		{
			return 0f;
		}

		private float GetZoom01(float zoomVal)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}

		private float ClampZoomFactor(float value)
		{
			return 0f;
		}

		private void ResetZoomFactor()
		{
		}

		private float GetZoomFactorLimitMidPoint()
		{
			return 0f;
		}

		private IEnumerator SetViewportFocusCoR(Vector2 newFocus)
		{
			return null;
		}

		public Vector3 GetAdjustedCameraPosition(float zoom)
		{
			return default(Vector3);
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

		public void ReleaseZoomLimits()
		{
		}

		public float ConvertZoomValue(float value)
		{
			return 0f;
		}

		public void ReleaseZoomCurve()
		{
		}

		public void ManualCustomCameraValues(float customZoom, Vector2 customViewportFocus)
		{
		}

		public void AddDialogueCameraBackFocus(ICameraBackPosition cameraMarker)
		{
		}

		public bool RunCameraBackToDialogue()
		{
			return false;
		}

		public bool RunCameraBackToDialogueInstant()
		{
			return false;
		}

		public void RemoveDialogueCameraForRunBack()
		{
		}
	}
}
