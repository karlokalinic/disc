using System.Collections;
using UnityEngine;

public class GraffitoFlameControl : MonoBehaviour
{
	public Light[] lites;

	public Renderer[] quads;

	public float duration;

	private float[] liteInitIntensities;

	public static GraffitoFlameControl instance;

	private float count;

	private void Start()
	{
	}

	public void On()
	{
	}

	public void Off()
	{
	}

	private IEnumerator To(bool to, float time = 0f)
	{
		return null;
	}
}
