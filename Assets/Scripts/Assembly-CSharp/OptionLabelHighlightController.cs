using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionLabelHighlightController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	[SerializeField]
	private Selectable selectable;

	[SerializeField]
	private OptionSelectableController selectableController;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
