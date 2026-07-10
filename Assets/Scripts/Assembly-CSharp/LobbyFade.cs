using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LobbyFade : MonoBehaviour
{
	private const float FADING_TIME = 1f;

	private const float DELAY_TIME = 1f;

	private const float SMOOTH_FACTOR = 0.1f;

	[SerializeField]
	private RawImage rawImage;

	public RawImage RawImage => null;

	protected void Start()
	{
	}

	public void FadeAndDestroy()
	{
	}

	private IEnumerator FadeLobbyCoroutine()
	{
		return null;
	}

	public void DestroyChildrenExcept(params GameObject[] except)
	{
	}
}
