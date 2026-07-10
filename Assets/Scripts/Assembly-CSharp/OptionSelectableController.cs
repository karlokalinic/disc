using DG.Tweening;
using Sunshine;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionSelectableController : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	private const float FADE_TIME = 0.23f;

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private Graphic[] additionalImages;

	[SerializeField]
	private TooltipSource tooltip;

	[HideInInspector]
	public Selectable selectable;

	private Sequence selectionSequence;

	private Color initTextCol;

	private Color initImageCol;

	private Color selectedTextCol;

	private static OptionSelectableController lastHighlightedSelectable;

	private bool isHighlighted;

	public bool IsHighlighted => false;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void TriggerPointerEnter()
	{
	}

	public void TriggerPointerExit()
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void PlaySelectedSequence()
	{
	}

	private void PlayUnselectedSequence(bool immediate = false)
	{
	}

	private void AddImagesFromAllChildrenToAdditionalImages()
	{
	}
}
