using System;
using FortressOccident;
using IOSCamera;
using Sunshine;
using UnityEngine;

public static class CameraSelector
{
	private static CameraController GetCameraController => null;

	private static iOSCameraControllerTest GetIosCameraController => null;

	public static float TouchZoom
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static void AddOnCameraMoveEvent(Action OnCameraMove)
	{
	}

	public static void RemoveOnCameraMoveEvent(Action OnCameraMove)
	{
	}

	public static void UpdateZoomLimiters()
	{
	}

	public static void SetFocus(Vector3 newPosition, float? newZoomFactor = null, bool instant = false)
	{
	}

	public static void SetViewportAndFocus(Vector2 newFocus, Vector3 newPosition, float? newZoomFactor = null, bool instant = false)
	{
	}

	public static void SetFocusAndViewport(Vector3 newPosition, float? newZoomFactor, bool instant, Vector2 newFocus)
	{
	}

	public static void ReturnCameraToMainCharacter()
	{
	}

	public static Vector3 GetAdjustedCameraPosition(float zoom)
	{
		return default(Vector3);
	}

	internal static void SetCameraOnGameplayStart()
	{
	}

	public static void ManualCustomCameraValues(float customZoom, Vector2 customViewportFocus)
	{
	}

	public static void AddDialogueCameraBackFocus(ICameraBackPosition cameraMarker)
	{
	}

	public static void RunCameraBackToDialogueInstant()
	{
	}

	public static bool AddLock(object lockObj)
	{
		return false;
	}

	public static bool RemoveLock(object lockObj)
	{
		return false;
	}

	public static bool CheckLock(object lockObj)
	{
		return false;
	}

	public static bool RemoveAllLocksAndCenterViewport()
	{
		return false;
	}
}
