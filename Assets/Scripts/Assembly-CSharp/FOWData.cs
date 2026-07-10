using System.Collections.Generic;
using UnityEngine;

public class FOWData
{
	public Renderer renderer;

	public Mesh mesh;

	public Vector2[] texcoords;

	public Rect rect;

	private List<Vector3> vert;

	public FOWData(Renderer r, Mesh m)
	{
	}

	public void ApplyTexcoords()
	{
	}

	public void Update(in Vector3 cameraForward, in Vector3 playerHeadPos)
	{
	}
}
