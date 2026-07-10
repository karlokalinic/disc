using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PropagateColour : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Text target;

	private ColorBlock colors;

	private void Start()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
