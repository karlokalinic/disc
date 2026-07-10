using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIChangeTMProColorOnSelect : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[SerializeField]
	private TextMeshProUGUI textToChangeColor;

	[SerializeField]
	private Color selectColor;

	[SerializeField]
	private Color32 deselectColor;

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}
}
