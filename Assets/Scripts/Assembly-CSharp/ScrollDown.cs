using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

public class ScrollDown : SingletonComponent<ScrollDown>
{
	private const float SCROLL_SPEED = 1000f;

	public Action OnCull;

	[SerializeField]
	private RectTransform logStack;

	public SlideScroller foScroll;

	public RectTransform staticMarker;

	public RectTransform staticTopMarker;

	public RectTransform topMarker;

	public RectTransform botMarker;

	public RectTransform movingMarker;

	public RectTransform staticBotMarker;

	public RectTransform paddedPanel;

	public bool logEmpty;

	private ScrollRect rect;

	private Scrollbar scrollbar;

	private RectTransform content;

	private float savedRelativeDistance;

	private int scrolling;

	private bool lockInPlace;

	private Vector3 lastWorldPosition;

	private Coroutine scrollToSelected;

	protected override void Awake()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	protected void OnTextSizeChanged(TextSizeConfiguration.TextSize textSize)
	{
	}

	protected IEnumerator DelayedRebuilder()
	{
		return null;
	}

	protected void RefreshLayout()
	{
	}

	public void Update()
	{
	}

	public float VerticalPosition(RectTransform r)
	{
		return 0f;
	}

	public Vector3 GetScreenPos(RectTransform r)
	{
		return default(Vector3);
	}

	private void UpdateVerticalPosition(RectTransform target, RectTransform source, RectTransform marker)
	{
	}

	private void UpdateVerticalPosition(RectTransform target, Vector3 sourcePosition, RectTransform marker)
	{
	}

	private void StartScrollContent()
	{
	}

	private void MoveTowardsTargetHeight()
	{
	}

	private static float GetSpeed()
	{
		return 0f;
	}

	private void UpdateContentPosition(float speed)
	{
	}

	private void StopScrolling()
	{
	}

	public void OnValueChanged()
	{
	}

	public void SetInitialPosition()
	{
	}

	public void LogWasUpdated()
	{
	}

	public void SavePosition(RectTransform marker, RectTransform relativeTo)
	{
	}

	public void RestorePosition(RectTransform marker, RectTransform relativeTo)
	{
	}

	public void RestorePositionFromDeltaPosition(RectTransform marker, RectTransform staticMarker, RectTransform relativeTo)
	{
	}

	public void TryScrollToResponse(RectTransform response)
	{
	}

	private IEnumerator ScrollToBottom(RectTransform response)
	{
		return null;
	}
}
