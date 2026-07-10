using UnityEngine;
using Voidforge;

public class FeldCameraBehaviour : SingletonComponent<FeldCameraBehaviour>
{
	private Camera _feldCam;

	private Camera cam;

	private bool d3d;

	private Matrix4x4 V;

	private Matrix4x4 P;

	private Matrix4x4 VP;

	private float feldCamSize;

	public static Camera FeldCam => null;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPreRender()
	{
	}
}
