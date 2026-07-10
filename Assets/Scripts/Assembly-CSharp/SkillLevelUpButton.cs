using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillLevelUpButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private Button button;

	private Image levelUpButtonImage;

	private Sprite levelUpGreySprite;

	[SerializeField]
	private GameObject controllerButtonPrompt;

	private static string LevelUpButtonGreyTerm => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
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

	public void SetInteractable(bool state)
	{
	}

	private void ChangeActiveStateOfButtonPrompt(bool state)
	{
	}

	private void UpdateLevelUpGreyButton()
	{
	}
}
