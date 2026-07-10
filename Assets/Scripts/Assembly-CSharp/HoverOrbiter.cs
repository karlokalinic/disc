using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOrbiter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private bool isEnabled;

	private bool hovering;

	public void Initialize(SenseOrb orb)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnDisable()
	{
	}
}
