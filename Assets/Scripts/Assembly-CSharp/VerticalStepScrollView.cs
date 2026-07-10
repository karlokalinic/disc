using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class VerticalStepScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	private const float tweenEndThreshold = 1f;

	[SerializeField]
	protected float stepSize;

	[SerializeField]
	private float separatorSize;

	[SerializeField]
	private float tweenTimeFactor;

	[SerializeField]
	protected RectTransform viewport;

	[SerializeField]
	protected RectTransform content;

	private ScrollRect scrollRect;

	private bool isTweening;

	private bool isDragging;

	private int targetStep;

	private float targetVerticalPosition;

	public UnityEvent OnTargetStepChanged;

	private float separatorsDelta;

	public int MaxSteps => 0;

	public int TargetStep
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private float VerticalPosition
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void RegisterSelectionEvent()
	{
	}

	public void UnregisterSelectionEvent()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void OnScroll(PointerEventData eventData)
	{
	}

	public void Refresh()
	{
	}

	public void AddSeparator()
	{
	}

	public void RemoveSeparator()
	{
	}

	private void OnValueChanged(Vector2 newValue)
	{
	}

	private float CalculateTargetStepPosition(int step)
	{
		return 0f;
	}

	private float CalculateDeltaToStep(int step)
	{
		return 0f;
	}

	private int CalculateClosestStep()
	{
		return 0;
	}

	private void ChangeStepImmediately(int targetStep)
	{
	}

	public IEnumerator RefreshAndUpdateSelectionCoroutine(Selectable newSelection)
	{
		return null;
	}

	public virtual void OnSelectionChanged(Selectable newSelection)
	{
	}

	private static bool CheckIfIsOutsideTarget(RectTransform viewport, RectTransform selectedTransform)
	{
		return false;
	}

	private static Vector3[] GetCornersInViewportLocalSpace(RectTransform viewport, RectTransform selectedTransform)
	{
		return null;
	}
}
