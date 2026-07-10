using UnityEngine;
using UnityEngine.EventSystems;

public class SkillPortraitSelection : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[SerializeField]
	private SkillPortraitPanel skillPortraitPanel;

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}
}
