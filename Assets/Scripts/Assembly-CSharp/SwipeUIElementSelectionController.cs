using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DiscoPages.Elements.Common;
using UnityEngine;

public class SwipeUIElementSelectionController : MonoBehaviour
{
	private const float GO_BACK_DURATION = 0.33f;

	private const float GO_TO_NEXT_DURATION = 0.33f;

	private const float FADE_DURATION = 0.16f;

	private const float PROGRESS_TO_ACCEPT_SWIPE = 0.28f;

	private const float SPEED_CONDITION_VALUE = 7f;

	[SerializeField]
	protected CanvasGroup[] uiElementsToHideOnSwipe;

	[SerializeField]
	private RectTransform middleElement;

	[SerializeField]
	private RectTransform leftElement;

	[SerializeField]
	private RectTransform rightElement;

	private Sequence swipeLeftSequence;

	private Sequence swipeRightSequence;

	private Sequence goBackSequence;

	private Sequence fadeSequence;

	private bool waitForSequenceToEnd;

	private bool swipeStarted;

	private float actualScreenWidth;

	public event Action OnNavigatedLeft
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnNavigatedRight
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void KillTweens()
	{
	}

	private void OnSwipeStarted(SwipeDetector.SwipeData data)
	{
	}

	private void OnSwipe(SwipeDetector.SwipeData data)
	{
	}

	private void OnSwipeEnded(SwipeDetector.SwipeData data)
	{
	}

	private void PrepareAnimationSequences()
	{
	}
}
