using System;
using System.Collections;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class CameraMarker : CameraSettings, ICameraBackPosition
	{
		public static bool isCameraMarkerInitialized;

		[SerializeField]
		private bool isDialogueMarker;

		[SerializeField]
		protected Vector3 offset;

		[SerializeField]
		protected bool setDuration;

		[SerializeField]
		protected Vector3 durations;

		[NonSerialized]
		public CameraStartFrom cameraStartFrom;

		public float restoreZoom;

		public Vector2 restoreViewportFocus;

		private Vector3 restoreDurations;

		private static float restoreZoomStatic;

		private static Vector2 restoreViewportFocusStatic;

		private ComponentRef<BaseParameter> noTweenParameter;

		private static CameraMarker realTimeEditTarget;

		public Vector3 targetPosition => default(Vector3);

		private Vector3 youPosition => default(Vector3);

		private bool noTween => false;

		public static void Copy(CameraMarker from, CameraMarker to)
		{
		}

		public static void MoveCameraToPreviousFocusAndZoom()
		{
		}

		public static void MoveCameraToCenter()
		{
		}

		public static void InventoryActivate(Component component, bool active, bool isTHC, bool isNextViewDialogue = false)
		{
		}

		private static void SetViewFocusAfterInventory(CameraMarker marker, Vector2 newViewportValue)
		{
		}

		private static void RestoreViewFocus(CameraMarker marker)
		{
		}

		public static void SetRestoreValuesForMarker()
		{
		}

		public void RunBack(bool instant = false)
		{
		}

		public bool HaveConversant()
		{
			return false;
		}

		private IEnumerator ActiveCoR(bool isOrb = false, bool setRestore = true)
		{
			return null;
		}

		public static void PrepareCameraRestorePoint(bool blockIfLocked = false)
		{
		}

		private IEnumerator InactiveCoR()
		{
			return null;
		}

		private static IEnumerator TweenCameraToCenter()
		{
			return null;
		}

		private static IEnumerator TweenCameraToPreviousFocusAndZoom()
		{
			return null;
		}

		public void OnGameEntityActivation(bool isActive)
		{
		}

		public void OnOrbActivation(bool isActive)
		{
		}

		public void ManualRevertCameraPosition()
		{
		}

		private void EditRealtimeStart()
		{
		}

		private void EditRealtimeEnd()
		{
		}

		public void OnValidate()
		{
		}
	}
}
