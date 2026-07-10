using System.Collections;
using UnityEngine;

public class Camshake : MonoBehaviour
{
	public AnimationCurve shakeProfileX;

	public float shakeProfileXScale;

	public AnimationCurve shakeProfileY;

	public float shakeProfileYScale;

	public AnimationCurve shakemask;

	public float shakemaskScale;

	public Vector3 home;

	public static Camshake instance;

	private Coroutine cor;

	private void Start()
	{
	}

	public static void Shake(float intensity = 1f)
	{
	}

	private IEnumerator CamshakeCoR(float intensity)
	{
		return null;
	}

	private void shaketest()
	{
	}
}
