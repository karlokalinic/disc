using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RollAbilitiesButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IGenericTooltipDataProvider
{
	private Button button;

	private void Start()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}
