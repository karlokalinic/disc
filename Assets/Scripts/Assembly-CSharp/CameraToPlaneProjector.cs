using UnityEngine;
using Voidforge;

public class CameraToPlaneProjector : SingletonComponent<CameraToPlaneProjector>
{
	private const float RECT_OFFSET = 5f;

	public static Vector3 min;

	public static Vector3 max;

	public static Rect rectMinMax;

	private int prevScreenSize;

	private int crntScreenSize;

	public static CameraToPlaneProjector instance;

	private Vector3 scrMin;

	private Vector3 scrMax;

	private Ray rayMin;

	private Ray rayMax;

	private Plane groundPlane;

	public static Camera cam;

	private float minLength;

	private float maxLength;

	private float orthoRemember;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void RefreshCamParams()
	{
	}

	private void PopulateMinMax()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public Vector3 CameraRaycastToHeight(float height)
	{
		return default(Vector3);
	}

	public Vector3 CameraRaycast(float height, int widthDivider = 2, int heightDivider = 2)
	{
		return default(Vector3);
	}
}
