using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SetSignatureButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IGenericTooltipDataProvider
{
	private Button button;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}
