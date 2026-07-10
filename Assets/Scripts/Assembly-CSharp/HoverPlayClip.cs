using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverPlayClip : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	public AudioSource audioSource;

	public AudioClip audioClip;

	public Button button;

	public void OnPointerEnter(PointerEventData ped)
	{
	}
}
