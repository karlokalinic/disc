using System.Collections;
using UnityEngine;

public class AuthoritySpotlightMask : MonoBehaviour
{
	public float fadeTime;

	private MeshRenderer r;

	private Material mat;

	private Light light;

	private float lightIntensity;

	public static AuthoritySpotlightMask instance;

	private float mullenness;

	private Coroutine mullenCoR;

	private bool IsOn => false;

	private void Start()
	{
	}

	private void DisableIfOn()
	{
	}

	public void Engage(bool to)
	{
	}

	private IEnumerator FadeToMullen(bool to)
	{
		return null;
	}

	private void On()
	{
	}

	private void Off()
	{
	}
}
