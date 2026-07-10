using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VerticalStepScrollViewSlider : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[SerializeField]
	private VerticalStepScrollView scrollViewFixedSteps;

	private Slider slider;

	private bool isDragging;

	private void Awake()
	{
	}

	private void OnDestroy()
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

	private void OnSliderValueChanged(float value)
	{
	}

	private void OnScrollRectValueChanged()
	{
	}

	private void UpdateSliderValue()
	{
	}

	private void UpdateTargetStep()
	{
	}
}
