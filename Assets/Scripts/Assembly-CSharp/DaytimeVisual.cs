using UnityEngine;

[CreateAssetMenu]
public class DaytimeVisual : ScriptableObject
{
	[Space]
	public Daytime daytime;

	public Texture2D shadowGrad;

	public float sunIntensity;

	public Transform sunTransform;

	public Color sky;

	public float skyIntensity;

	private void OnValidate()
	{
	}
}
