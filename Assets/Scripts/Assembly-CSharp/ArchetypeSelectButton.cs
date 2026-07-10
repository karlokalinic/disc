using I2.Loc;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ArchetypeSelectButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, ISelectHandler, ISubmitHandler
{
	public bool IsCustomCharacterButton;

	public ArchetypeButtonAnimatorHelper animatorHelper;

	public Image portrait;

	public Image portraitHoverOverlay;

	public Localize NameLocalization;

	public ArchetypeAbility Int;

	public ArchetypeAbility Psy;

	public ArchetypeAbility Phq;

	public ArchetypeAbility Mot;

	public Localize SignatureSkillLocalization;

	public Localize DescriptionLocalization;

	public Button goButton;

	public int selectionIndex;

	private Selectable mySelectable;

	public SunshineCharacterTemplate Archetype { get; private set; }

	public Selectable MySelectable => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetArchetype(SunshineCharacterTemplate archetype)
	{
	}

	private void SetTerms()
	{
	}

	public void SetPortrait(Sprite sprite)
	{
	}

	public void SetSelected(bool isSelected, bool isOtherSelected)
	{
	}

	public void OnPointerEnter(PointerEventData e)
	{
	}

	public void OnPointerExit(PointerEventData e)
	{
	}

	public void OnPointerClick(PointerEventData e)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void PlayShowAnimation()
	{
	}

	public void PlayHideAnimation()
	{
	}
}
