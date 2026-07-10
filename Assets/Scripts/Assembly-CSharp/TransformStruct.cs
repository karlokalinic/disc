using System;
using UnityEngine;

[Serializable]
public struct TransformStruct
{
	public Transform transform;

	public Vector3 localPosition;

	public Quaternion localRotation;

	public Vector3 localScale;

	public bool worldSpace;

	public TransformStruct(Vector3 pos, Quaternion rot, Vector3 sca, Transform xform, bool ws)
	{
		transform = null;
		localPosition = default(Vector3);
		localRotation = default(Quaternion);
		localScale = default(Vector3);
		worldSpace = false;
	}

	public static void Lerp(TransformStruct from, TransformStruct to, float t, Transform xform)
	{
	}

	public static TransformStruct Lerp(TransformStruct from, TransformStruct to, float t)
	{
		return default(TransformStruct);
	}

	public TransformStruct ToWorldSpace()
	{
		return default(TransformStruct);
	}

	public void CopyFrom(TransformStruct ts)
	{
	}
}
