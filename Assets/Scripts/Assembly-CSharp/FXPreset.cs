using System;
using UnityEngine;

[Serializable]
public class FXPreset
{
	public string name;

	public Material material;

	public float length;

	public AnimationCurve animation;

	public bool toggle;

	[HideInInspector]
	public float time;

	[HideInInspector]
	public AnimationDirection dir;

	[HideInInspector]
	public CameraFX attachedTo;

	[HideInInspector]
	public PostFXBase component;
}
