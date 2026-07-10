using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

public class OverallOverlayImage : SingletonComponent<OverallOverlayImage>
{
	public Image image;

	private Coroutine forceDisableCoroutine;

	private Coroutine fadeCoroutine;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void FadeToBlack(float fadeTime, bool ignoreTimeScale = false)
	{
	}

	private void StopFadeCoroutine()
	{
	}

	private void StopForceDisableCoroutine()
	{
	}

	public void FadeBack(float fadeTime, bool ignoreTimeScale = false)
	{
	}

	public void FadeBackIfNotAlreadyFading(float fadeTime, bool ignoreTimeScale = false)
	{
	}

	private IEnumerator DeactivateAfterFade(float fadeTime, bool useRealtime)
	{
		return null;
	}

	private void DisableBlackScreenAfterMapChange()
	{
	}

	private IEnumerator ForceDisableCoroutine()
	{
		return null;
	}
}
