using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SlideScroller : MonoBehaviour
{
	public Slider slider;

	public Scrollbar scrollbar;

	private CanvasGroup handleGroup;

	private Sequence sequence;

	private bool paused;

	private bool _isProcessing;

	public bool Paused => false;

	private void Awake()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void UpdateSlider()
	{
	}

	public void UpdateScrollbar()
	{
	}
}
