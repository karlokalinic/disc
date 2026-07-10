using UnityEngine;
using Voidforge;

public abstract class HudElementController : MonoBehaviour
{
	public AnimationCurve appearCurve;

	public AnimationCurve disappearCurve;

	protected UITweenCanvasgroupAlpha canvasTween;

	protected CanvasGroup canvasGroup;

	public virtual void Awake()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void DisableOnEnd()
	{
	}
}
