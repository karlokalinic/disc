using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ThoughtSlotHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	[SerializeField]
	private Image _slotGlow;

	private Image[] extraImages;

	private bool forceHover;

	private bool isHovered;

	private bool isSelected;

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerEnter(PointerEventData e)
	{
	}

	public void OnPointerExit(PointerEventData e)
	{
	}

	public void SetSelected(bool value)
	{
	}

	public void SetSprite(Sprite newSprite)
	{
	}

	private void SetVisibility()
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}
}
