using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FortressOccident;
using Sunshine;
using UnityEngine;
using Voidforge;

namespace IOSCamera
{
	public class iOSCameraControllerTest : FOComponent
	{
		[SerializeField]
		private Camera camera;

		[SerializeField]
		private iOSZoomController zoomController;

		[SerializeField]
		private iOSCameraPositionController positionController;

		private ComponentRef<TweenCamera> cameraTween;

		private iOSCameraLock iOSCameraLock;

		public static iOSCameraControllerTest Current { get; private set; }

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

		private void Reset()
		{
		}

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FinishTween()
		{
		}

		public void ForceCameraPosition(Vector3 newPosition)
		{
		}

		public float GetCameraZoom()
		{
			return 0f;
		}

		public void ForceCameraZoom(float v)
		{
		}

		public void ForceCameraZoomValue(float v)
		{
		}

		public Vector3? GetCameraFocus()
		{
			return null;
		}

		public void AttachToCharacter()
		{
		}

		public void FocusOnTarget(Vector3 newPosition, float? newZoomFactor, bool instant)
		{
		}

		private IEnumerator WaitForEndOfCameraTween()
		{
			return null;
		}

		public void SetTargetAndFocus(Vector2 newFocus, Vector3 newPosition, float? newZoomFactor, bool instant)
		{
		}

		public void ReturnCameraToMainCharacter(bool instant = false)
		{
		}

		public Vector3 GetAdjustedCameraPosition(float zoom)
		{
			return default(Vector3);
		}

		public void UpdateZoomLimiters()
		{
		}

		public bool AddLock(object lockObj)
		{
			return false;
		}

		public bool RemoveLock(object lockObj)
		{
			return false;
		}

		public bool CheckLock(object lockObj)
		{
			return false;
		}

		public bool RemoveAllLocksAndCenterViewport()
		{
			return false;
		}

		private void IOSCameraLock_LockedEvent(bool isLocked)
		{
		}
	}
}
