using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryHighlighter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	[SerializeField]
	private GameObject inventoryActiveBorder;

	private GameObject border;

	private static InventoryHighlighter currentlyHightlighted;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	void IDeselectHandler.OnDeselect(BaseEventData eventData)
	{
	}

	void ISelectHandler.OnSelect(BaseEventData eventData)
	{
	}

	private void PlaySelectionSound()
	{
	}
}
