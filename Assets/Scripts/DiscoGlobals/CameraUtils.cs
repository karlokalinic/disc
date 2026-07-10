using System;
using UnityEngine;

public class CameraUtils : MonoBehaviour
{
	private Camera cam;

	private static Plane[] _mainFrustumPlanes;

	public static Action OnLateUpdateCall;

	public static Action OnPreCullCall;

	public static Action OnPreRenderCall;

	private const string MainCameraTag = "MainCamera";

	private Rect camRect;

	private bool UpdateRect;

	public static Camera main { get; private set; }

	public static Transform mainTransform { get; private set; }

	public static Plane[] mainFrustumPlanes
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	private void CacheCamera()
	{
	}

	private void CacheMainCamera()
	{
	}

	private static void CheckUpdateMainCamera()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPreCull()
	{
	}

	private void ResetGrabPasses()
	{
	}

	private void OnOverscanChanged(float per, float size)
	{
	}

	private void OnPreRender()
	{
	}

	private void UpdateViewportRect(float per, float size)
	{
	}
}
